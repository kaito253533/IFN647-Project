using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syn.WordNet;
namespace RetrievalSystem
{
    public class WordNet
    {
        public WordNet() {

        }

        public static List<string> GetSynonyms(string word) {
            var wordNet = new WordNetEngine();
            var directory = Directory.GetCurrentDirectory();
            wordNet.LoadFromDirectory(@".\dict");
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, @".\dict\data.adj")), PartOfSpeech.Adjective);
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, @".\dict\data.adv")), PartOfSpeech.Adverb);
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, @".\dict\data.noun")), PartOfSpeech.Noun);
            wordNet.AddDataSource(new StreamReader(Path.Combine(directory, @".\dict\data.verb")), PartOfSpeech.Verb);

            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, @".\dict\index.adj")), PartOfSpeech.Adjective);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, @".\dict\index.adv")), PartOfSpeech.Adverb);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, @".\dict\index.noun")), PartOfSpeech.Noun);
            wordNet.AddIndexSource(new StreamReader(Path.Combine(directory, @".\dict\index.verb")), PartOfSpeech.Verb);
            
            wordNet.Load();
            List<string> result = new List<string>();
            foreach (SynSet s in wordNet.GetSynSets(word))
            {
                List<string> temp = s.Words;
                result.AddRange(temp);
            }

            return result.Distinct().ToList();
        }
    }
    
}
