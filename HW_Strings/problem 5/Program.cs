using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_5
{
    class Unicode_Characters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                int asciiNumberInDec = input[i] + 0;
                string asciiNumberInHex = asciiNumberInDec.ToString("X4");
                Console.Write("\\u" + asciiNumberInHex);
            }
            Console.WriteLine(); 
        }
    }
}
