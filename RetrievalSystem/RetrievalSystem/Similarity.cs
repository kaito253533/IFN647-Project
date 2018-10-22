using System;
using Lucene.Net.Search;
using FieldInvertState = Lucene.Net.Index.FieldInvertState;

namespace RetrievalSystem
{
    public class TFSimilarity : DefaultSimilarity 
    {
       
           public override float Tf(float freq)
            {
               
                return (float)System.Math.Sqrt(freq);
            }

        
    }
}



//public override float Tf(float freq)
//{
//    //return (float)System.Math.Sqrt(freq);
//    return 1;
//}



//java
//    public class PayloadSimilarity extends ClassicSimilarity
//{

//    public float scorePayload(int doc, int start, int end, BytesRef payload)
//{
//    if (payload != null)
//    {
//        return PayloadHelper.decodeFloat(payload.bytes, payload.offset);
//    }
//    else
//    {
//        return 1;
//    }
//}

//@Override
//    public String toString()
//{
//    return "PayloadSimilarity";
//}
//}