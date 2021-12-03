using System;

namespace ExMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 11, 26, 10, 40, 00);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
