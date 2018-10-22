using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FieldInvertState = Lucene.Net.Index.FieldInvertState;
using Lucene.Net.Search;

namespace RetrievalSystem
{
    class CustomSimilarity : Lucene.Net.Search.DefaultSimilarity
    {
        //Inverse document frequency
        public override float Idf(int docFreq, int numDocs)
        {
            return (float)(System.Math.Log(numDocs / (double)(docFreq + 1)) + 1.0);
        }

    }
}
