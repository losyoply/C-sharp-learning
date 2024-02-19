using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Caculator c = new Caculator();
            Action myAction = new Action(c.PrintHello);  //委託的使用
            myAction();
        }
    }

    class Caculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
