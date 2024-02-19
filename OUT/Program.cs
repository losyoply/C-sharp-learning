using System;

namespace OUT
{
    class Program
    {
        static void Main(string[] args)
        {
            //out使用方法
            int num1 = 20;
            int num2 = 30;
            int max;
            int min;
            Compare(num1, num2, out max, out min);
            Console.WriteLine("{0} {1}", max, min);
        }

        static void Compare(int number1, int number2, out int max, out int min)
        {
            if(number1>number2)
            {
                max = number1;
                min = number2;
            }
            else
            {
                max = number2;
                min = number1;

            }
        }
    }
}
