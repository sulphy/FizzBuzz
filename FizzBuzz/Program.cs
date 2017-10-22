using System;

namespace FizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("FizBuzz Test");
            var fbObject = new FizzBuzz();
            fbObject.FizzBuzzGenerator();
        }
    }
}
