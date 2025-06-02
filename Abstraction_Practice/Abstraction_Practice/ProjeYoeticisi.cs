using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Abstraction_Practice
{
    internal class ProjeYoeticisi : Pozisyon
    {
       public override void Gorev()
        {
            Console.WriteLine("Proje yoneticisi olarak calisiyorum.");
        }


    }
}
