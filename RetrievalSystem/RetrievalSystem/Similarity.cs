using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lucene.Net.Search;
using FieldInvertState = Lucene.Net.Index.FieldInvertState;

namespace RetrievalSystem
{
    public class NewSimilarity : DefaultSimilarity
    {
        //Math Log is added to the default TF weighitng
        public override float Tf(float freq)
        {
            
            return (float)(Math.Log(freq) + 1);
        }

        public override float Idf(int docFreq, int numDocs)
        {
            return (float)(Math.Log(numDocs / (double) (docFreq + 1)) + 1.0);
        }


    }
}
