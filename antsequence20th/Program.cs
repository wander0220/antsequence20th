using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antsequence20th
{
    class Program
    {
        static void Main(string[] args)
        {

            //인터넷 참고하면서 했습니다...

            int[] ant = new int[10000];
            int[] bnt = new int[10000];
            ant[0] = 1;

            int count = 1;
            int j;
            int index;

            for(int i = 0; i < 20; i++)
            {
                j = 0;
                index = 0;
                Console.Write((i + 1) + "번 째 수열 : ");                

                while(ant[j]!=0)
                {
                    if (ant[j] == ant[j + 1]) count++;
                    else
                    {
                        bnt[index++] = ant[j];
                        bnt[index++] = count;
                    }

                    j++;
                }

                for(int n = 0; n < bnt.Length; n++)
                {
                    ant[n] = bnt[n];
                }
                
                for(int n = 0; n < ant.Length; n++)
                {
                    if (ant[n] != 0)
                        Console.Write(ant[n]);
                }
                Console.WriteLine();
            }


        }
    }
}
