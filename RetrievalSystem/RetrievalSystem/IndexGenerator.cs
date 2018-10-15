﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Analysis;
using Lucene.Net.Documents;
using Lucene.Net.Index;
using Lucene.Net.Store;

namespace RetrievalSystem
{
    class IndexGenerator
    {

        Lucene.Net.Store.Directory indexDirectory;
        Analyzer analyzer;
        IndexWriter writer;
        public static Lucene.Net.Util.Version VERSION = Lucene.Net.Util.Version.LUCENE_30;

        // Constructer
        public IndexGenerator()
        {
            indexDirectory = null;
            analyzer = new Lucene.Net.Analysis.SimpleAnalyzer();
            writer = null;
        }

        public Boolean IsDirectoryEmpty(string indexPath)
        {
            // To make sure the directory is not existing.
            // If that is existing, empty that?
            if (System.IO.Directory.Exists(indexPath))
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(indexPath);
                if (di.GetFiles().Count() > 0)
                {
                    return false;
                }
                return true;
            }
            return true;
        }

        public void DeleteFiles(string indexPath)
        {
            System.IO.DirectoryInfo di = new DirectoryInfo(indexPath);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        // Set path into Lucene Directory and Create a Writer
        public void SettingConfiguration(string indexPath)
        {
            indexDirectory = Lucene.Net.Store.FSDirectory.Open(indexPath);
            IndexWriter.MaxFieldLength mfl = new IndexWriter.MaxFieldLength(IndexWriter.DEFAULT_MAX_FIELD_LENGTH);

            // TODO: Enter code to create the Lucene Writer
            writer = new Lucene.Net.Index.IndexWriter(indexDirectory, analyzer, true, mfl);
        }

        // Indexing...
        public void IndexText(List<Collection> collections)
        {
            foreach (Collection c in collections)
            {
                Lucene.Net.Documents.Document doc = new Lucene.Net.Documents.Document();
                // TODO: Enter code to index text
                doc.Add(new Lucene.Net.Documents.Field("DocID", c.DocID, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                doc.Add(new Lucene.Net.Documents.Field("Title", c.Title, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                doc.Add(new Lucene.Net.Documents.Field("Author", c.Author, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                doc.Add(new Lucene.Net.Documents.Field("Bibliographic", c.Bibliographic, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                doc.Add(new Lucene.Net.Documents.Field("Words", c.Words, Field.Store.NO, Field.Index.ANALYZED, Field.TermVector.WITH_POSITIONS_OFFSETS));
                writer.AddDocument(doc);
            }
        }

        public List<Collection> Analyser(string collectionPath) {

            List<Collection> collctions = new List<Collection>();
            // Read the files from the collection directory
            System.IO.DirectoryInfo di = new DirectoryInfo(collectionPath);
            foreach (FileInfo file in di.GetFiles())
            {
                Collection collection = new Collection();
                string text = System.IO.File.ReadAllText(file.FullName);

                // Get Words
                string[] stringSeparators = new string[] { "\n.W\n" };
                string[] result = text.Split(stringSeparators, StringSplitOptions.None);
                collection.Words = result.Length != 1 ? result[1] : string.Empty;
                text = result[0];

                // Get Bibliographic
                stringSeparators = new string[] { "\n.B\n" };
                result = text.Split(stringSeparators, StringSplitOptions.None);
                collection.Bibliographic = result.Length != 1 ? result[1] : string.Empty;
                text = result[0];

                // Get Author
                stringSeparators = new string[] { "\n.A\n" };
                result = text.Split(stringSeparators, StringSplitOptions.None);
                collection.Author = result.Length != 1 ? result[1] : string.Empty;
                text = result[0];

                // Get Title
                stringSeparators = new string[] { "\n.T\n" };
                result = text.Split(stringSeparators, StringSplitOptions.None);
                collection.Title = result.Length != 1 ? result[1] : string.Empty;
                text = result[0];

                // Get DocID
                stringSeparators = new string[] { ".I" };
                result = text.Split(stringSeparators, StringSplitOptions.None);
                collection.DocID = result.Length != 1 ? result[1] : string.Empty;
                text = result[0];

                // Remove duplicated title in the abstract
                collection.Words = collection.Words.Replace(collection.Title + "\n", string.Empty);
                collctions.Add(collection);
            }

            return collctions;
        }
        // Main Process
        public void StartIndex(string indexPath, string collectionPath)
        {
            // Set up!
            SettingConfiguration(indexPath);

            // Read File and Analyse
            List<Collection> collections = Analyser(collectionPath);

            // Create Index
            IndexText(collections);

            //Clean
            CleanUp();
        }

        public void CleanUp()
        {
            writer.Optimize();
            writer.Flush(true, true, true);
            writer.Dispose();
        }

    }
}
