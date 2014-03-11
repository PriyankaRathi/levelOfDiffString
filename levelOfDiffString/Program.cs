using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace levelOfDiffString
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            string B = Console.ReadLine();
            var S = from i in Enumerable.Range(0, A.Length)
                    from j in Enumerable.Range(0, A.Length - i + 1)
                    where j >= 1
                    select A.Substring(i, j);
                              
            var T = from i in Enumerable.Range(0, B.Length)
                    from j in Enumerable.Range(0, B.Length - i + 1)
                    where j >= 1
                    select B.Substring(i, j);
           
            var P =S.Except(T).Union(T.Except(S));

            Console.Write(P.Count());

            //Console.ReadKey();
        }

       
    }
}
