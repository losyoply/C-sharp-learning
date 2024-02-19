using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuoTai
{
    class WomanEat:Eat
    {
        public override void Chifan()
        {
            base.Chifan();
            Console.WriteLine("woman eat");
            
        }
    }
}
