using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoTai
{
    class ManEat:Eat
    {
        public override void Chifan()
        {
            //base: 父類
            base.Chifan();
            Console.WriteLine("man eat");
        }
    }
}
