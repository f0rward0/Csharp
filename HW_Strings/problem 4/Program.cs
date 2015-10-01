﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4
{
    class Text_Filter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(',');
            string text = Console.ReadLine();
    
            for (int i = 0; i < bannedWords.Length; i++)
            {
                bannedWords[i] = bannedWords[i].Trim();
                text = text.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
