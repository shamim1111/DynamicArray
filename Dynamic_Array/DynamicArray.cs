using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    class DynamicArray
    {
        /// <summary>
        /// This method processes the dynamic array based on the hacker rank algorithm.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public List<int> ProcessDynamicArray(int n, List<List<int>> queries)
        {
            List<int> result = new List<int>();
            List<int> seq;
            List<List<int>> seqList = new List<List<int>>();
            int lastAnswer = 0;
            int seqListIndex = 0;
            int size = 0;
            for (int i = 0; i < n; i++)
            {
                seq = new List<int>();
                seqList.Add(seq);
            }
            foreach (var subQuery in queries)
            {   //when sub query value is 1
                if (subQuery[0] == 1)
                {
                    seqListIndex = (subQuery[1] ^ lastAnswer) % n;

                    seq = seqList[seqListIndex];
                    seq.Add(subQuery[2]);
                }
                else
                if (subQuery[0] == 2)// when sub query value is 2
                {
                    seqListIndex = (subQuery[1] ^ lastAnswer) % n;

                    seq = seqList[seqListIndex];
                    size = seq.Count;
                    lastAnswer = seq[subQuery[2] % size];
                    result.Add(lastAnswer);
                   


                }

               

            }

            
            return result;
        }
    }
}
