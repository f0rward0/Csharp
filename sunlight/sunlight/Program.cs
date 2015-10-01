using System;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        
        Console.WriteLine("{0}*{0}",new string('.',3*size/2));
        for(int i=0;i<size-1;i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",new string('.',1+i),new string('.',3*size/2-i-2));
        }
        for(int i=0;i<(size-1)/2;i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));
        }
        Console.WriteLine(new string('*', 3 * size));
        for (int i = 0; i < (size - 1) / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('.', size), new string('*', size));
        }
        for (int i = size-2; i >= 0; i--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', 1 + i), new string('.', 3 * size / 2 - i - 2));
        }
        Console.WriteLine("{0}*{0}", new string('.', 3 * size / 2));
    }
}
