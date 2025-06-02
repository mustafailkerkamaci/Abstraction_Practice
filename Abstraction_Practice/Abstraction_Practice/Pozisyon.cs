using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Practice
{
    internal abstract class Pozisyon
    {


        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }


        public abstract void Gorev();




    }
}
