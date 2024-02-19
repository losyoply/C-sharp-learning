using System;

namespace Jie_Kou_Duo_Tai
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.PP = "dog";
            car.Fly();
            Console.ReadKey();
        }
    }
}
