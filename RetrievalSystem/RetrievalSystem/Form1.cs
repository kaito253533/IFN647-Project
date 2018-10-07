using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetrievalSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
            IndexGenerator gernerator = new IndexGenerator();

            if (!gernerator.IsDirectoryEmpty(txt_IndexPath.Text))
            {
                if (MessageBox.Show("The directory is not empty, do you want to delete all the files inside? (Yes-Delete All, No-Select Again)",
                        "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    gernerator.DeleteFiles(txt_IndexPath.Text);
                    gernerator.StartIndex(txt_IndexPath.Text, txt_CollectionPath.Text);
                }
            }
            else
            {
                gernerator.StartIndex(txt_IndexPath.Text, txt_CollectionPath.Text);
            }
            
        }
    }
}
