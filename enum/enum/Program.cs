using System;

namespace hoetoenum
{
    class Program
{
    static void Main(string[] args)
    {
         MyDate date = MyDate.Fri;
        int a = (int)date;
        Console.WriteLine(a);
    }

    enum MyDate
    {
        Mon = 0,
        Tue = 1,
        Wed = 2,
        Thu = 3,
        Fri = 4,
        Sat = 5,
        Sun = 6,
    }
}
}
