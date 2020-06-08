using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ///you can enter 2 5 respectively to check the outcome as Hacker Rank
            Console.WriteLine("Please enter n and q value in the same line and with  the space then enter.");
            string[] inputArray = Console.ReadLine().TrimEnd().Split(' ');
            int nValue = Convert.ToInt32(inputArray[0]);
            int qValue = Convert.ToInt32(inputArray[1]);
            List<List<int>> queries = new List<List<int>>();
            //Initialize sub queries based on the inputs from hacker rank
            List<int> subQuery_01 = new List<int>() { 1, 0, 5 };
            queries.Add(subQuery_01);
            List<int> subQuery_02 = new List<int>() { 1, 1, 7 };
            queries.Add(subQuery_02);
            List<int> subQuery_03 = new List<int>() { 1, 0, 3 };
            queries.Add(subQuery_03);
            List<int> subQuery_04 = new List<int>() { 2, 1, 0 };
            queries.Add(subQuery_04);
            List<int> subQuery_05 = new List<int>() { 2, 1, 2 };
            queries.Add(subQuery_05);
           
            DynamicArray dArray = new DynamicArray();
            List<int> result = dArray.ProcessDynamicArray(nValue, queries);
            Console.WriteLine(string.Join("\n", result));
            Console.ReadKey();
        }
    }
}
