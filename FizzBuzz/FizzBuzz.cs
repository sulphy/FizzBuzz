using System;
namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string _value
        {
            get;
            set;
        }

        public void FizzBuzzGenerator()
        {

            for (var i = 0; i <= 100; i++){

                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    PrintResult("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    PrintResult("Fizz");
                }
                else if (i % 5 == 0)
                {
                    PrintResult("Buzz");
                }
                else PrintResult(i.ToString());
            }
        }

        private void PrintResult(string value)
        {
            _value = value;
            Console.WriteLine(_value);      
        }
    }
}
