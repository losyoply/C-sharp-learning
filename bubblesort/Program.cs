using System;

namespace bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 45, 27, 55, 3, 6, 2, 80, 90 };

            int a;

            for(int j = 0; j<num.Length-1;j++)
            {
                for(int i = 0;i<num.Length-1-j;i++)
                {
                    if(num[i]>num[i+1])
                    {
                        a = num[i + 1];
                        num[i + 1] = num[i];
                        num[i] = a;
                    }
                }
            }

            foreach(int item in num)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
