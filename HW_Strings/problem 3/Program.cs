using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_3
{
    class Count_Substring_Occurrences
    {
        static void Main(string[] args)
        {
            int x = 0;
            string input = Console.ReadLine();
            string key = Console.ReadLine();
            int count = 0;
            for(int i=0;i<=input.Length-key.Length;i++)
            {
                bool flag = true;
                for(int j=0;j<key.Length;j++)
                {
                    if(input[i+j]!=key[j])
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag==true)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            

        }
    }
}
