using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetrievalSystem
{
    public partial class Form1 : Form
    {
        IndexGenerator generator = new IndexGenerator();
        public Form1()
        {
            InitializeComponent();
            ddl_Type.SelectedIndex = 0;
            ddl_Fields.SelectedIndex = 0;
        }

        // Paging...
        int total = 0;
        int skip = 0;

        // Saving...
        int TopicID = 0;
        List<Collection> ResultCollectionList = new List<Collection>();

        #region Step 1: Indexing
        private void btn_CollectionPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please Choose Your Path of Collection";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                txt_CollectionPath.Text = sSelectedPath;
            }
        }

        private void btn_IndexPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please Choose Your Path for Indexing";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                txt_IndexPath.Text = sSelectedPath;
            }
        }

        private void btn_GenerateIndex_Click(object sender, EventArgs e)
        {
            // Check path
            if (String.IsNullOrEmpty(txt_CollectionPath.Text))
            {
                MessageBox.Show("Please Set the path of collection first!");
                return;
            }
            if (String.IsNullOrEmpty(txt_IndexPath.Text))
            {
                MessageBox.Show("Please Set the path of index first!");
                return;
            }


            // Do the index here.
            if (!generator.IsDirectoryEmpty(txt_IndexPath.Text))
            {
                if (MessageBox.Show("The directory is not empty, do you want to delete all the files inside? (Yes-Delete All, No-Select Again)",
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    generator.DeleteFiles(txt_IndexPath.Text);
                    Indexing(generator);
                }
            }
            else
            {
                Indexing(generator);
            }

            
        }

        private void Indexing( IndexGenerator generator)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            generator.StartIndex(txt_IndexPath.Text, txt_CollectionPath.Text);
            stopWatch.Stop();
            long ts = stopWatch.ElapsedMilliseconds;
            lbl_IndexingTime.Text = ts.ToString() + " ms";
        }

        #endregion

        #region Step 2: Searching
        private void Type_Click(object sender, EventArgs e)
        {
            if (ddl_Type.SelectedItem != "Single Term")
            {
                ddl_Fields.Visible = false;
            }
            else {
                ddl_Fields.Visible = true;
            }

        }
        private void lblSearch_Click(object sender, EventArgs e)
        {
            //Chech the saving path
            if (String.IsNullOrEmpty(txt_Saving.Text))
            {
                MessageBox.Show("Please choose a path to save results.");
                return;
            }
            if (String.IsNullOrEmpty(txt_FileName.Text))
            {
                MessageBox.Show("Please input a file name.");
                return;
            }

            btn_SaveBrowse.Visible = false;
            txt_Saving.ReadOnly = true;
            txt_FileName.ReadOnly = true;

            // Calculate the Process Time
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Searcher searcher = new Searcher(txt_IndexPath.Text, generator.analyzer, generator.writer);
            searcher.CreateSearcher();
            searcher.CreateParser(ddl_Type.SelectedItem.ToString(), ddl_Fields.SelectedItem.ToString());

            // Searching and generate result
            List<string> resultList = searcher.DisplayResults(searcher.SearchIndex(txt_InformationNeeds.Text), generator.collectionList);
            ResultCollectionList = generator.collectionList.Where(n => resultList.Contains(n.DocID)).ToList();
            stopWatch.Stop();
            long ts = stopWatch.ElapsedMilliseconds;
            lbl_SearchingTime.Text = ts.ToString() + " ms";

            // Set columns to listview
            GenerateListView();
            // Set the total number of documents
            total = resultList.Count();
            lblTotalDocs.Text = total + " docs";

            // Saving
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(String.Format("{0}\\{1}.txt",txt_Saving.Text, txt_FileName.Text), true))
            {
                foreach (Collection c in ResultCollectionList)
                {
                    string TopicIDString = string.Format("{0:000}", TopicID);
                    file.WriteLine(String.Format("{0} {1} {2} {3} {4} {5}", TopicIDString, "Q0", c.DocID, "Rank", "Score", "9913661_9913351_10032711_RetrievalHero"));
                }
                TopicID++;
            }
        }

        private void GenerateListView()
        {
            lv_Result.Clear();
            lv_Result.View = View.Details;
            lv_Result.Columns.Add("DocID", -2, HorizontalAlignment.Left);
            lv_Result.Columns.Add("Title", -2, HorizontalAlignment.Left);
            lv_Result.Columns.Add("Author", -2, HorizontalAlignment.Left);
            lv_Result.Columns.Add("Bibliographic", -2, HorizontalAlignment.Left);
            lv_Result.Columns.Add("Abtract", -2, HorizontalAlignment.Left);
            lv_Result.Columns.Add("", -2, HorizontalAlignment.Left);

            // Add items to listview
            foreach (Collection c in ResultCollectionList.Skip(skip).Take(10))
            {
                string abtractFirstSentence = c.Words.Split('.')[0];
                string[] row = { c.DocID, c.Title, c.Author, c.Bibliographic, string.IsNullOrEmpty(abtractFirstSentence) ? string.Empty : abtractFirstSentence.TrimEnd() + "." };
                var listViewItem = new ListViewItem(row);
                
                lv_Result.Items.Add(listViewItem);
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            // if skip >= 10, means the user is not in the first page! because it still can minus 10;
            if (skip >= 10)
            {
                skip = skip - 10;
                GenerateListView();
            }
            else
            {
                MessageBox.Show("You are in the first page!");
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            // if skip + 10 > total number of docs, means the user is in the last page!
            if (skip + 10 > total)
            {
                MessageBox.Show("You are in the last page!");
            }
            else
            {
                skip = skip + 10;
                GenerateListView();
            }
        }

        private void btn_SaveBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please choose a path to save results";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                txt_Saving.Text = sSelectedPath;
            }
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
