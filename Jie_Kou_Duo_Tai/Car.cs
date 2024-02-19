using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jie_Kou_Duo_Tai
{
    class Car:IFly
    {
        private string pp;
        public string PP
        {
            get { return pp; }
            set { pp = value; }
        }

        public void Fly()
        {
            Console.WriteLine("{0}汽車可以飛", pp);
        }
    }
}
