using System;

namespace DuoTai
{
    class Program
    {
        static void Main(string[] args)
        {
            ManEat man = new ManEat();
            man.Chifan();
            WomanEat woman = new WomanEat();
            woman.Chifan();
            Console.ReadKey();
        }
            
    }

   //abstract使用方法
   public abstract class MianJi
    {
        public abstract double MJ();
    }

    public class TuXing:MianJi
    {

        private double chang;
        private double kuan;

        public double Chang
        {
            get { return chang; }
            set { chang = value; }
        }
        public double Kuan
        {
            get { return kuan; }
            set { kuan = value; }
        }
        public override double MJ()
        {
            return chang * kuan;
        }
    }
}
