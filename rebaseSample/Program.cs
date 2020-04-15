using System;

namespace rebaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Getlimit(string name)
        {
            return name.Length;
        }

        public int GetlimitEx(string name)
        {
            return name.Length * 2;
        }

    }

    
}



