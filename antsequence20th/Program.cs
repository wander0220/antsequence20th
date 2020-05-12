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
            string num="1";
            int i;

            for (i = 0; i < 20; i++)
            {
                Console.Write((i + 1) + "번째 수열 : "+num);
                int cnt = 0;
                char check = num[0];
            
                for(int j = 0; j < num.Length; i++)
                {
                    if (check == num[j])
                    {
                        cnt++;
                    }
                    else
                    {
                        
                    }
                }
                
            }


        }
    }
}
