using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Practice
{
    internal class YazilimGelistirici : Pozisyon
    {
        public override void Gorev()
        {
            Console.WriteLine("Yazilim gelistirici olarak calisiyorum.");
        }
    }
}
