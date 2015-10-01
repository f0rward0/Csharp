using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_6
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '.', '!', ',', '?' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> palindromes=new SortedSet<string>();

            for(int i=0;i<words.Length;i++)
            {
                if(isPalidrome(words[i])!="no")
                {
                    palindromes.Add(words[i]);
                }
            }
            Console.WriteLine(string.Join(", ", palindromes));

        }
        static string isPalidrome(string value)
        {
            if (value == Reverse(value))
            {
                return value;
            }
            else
                return "no";
        }
        static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }



        
    }

}
