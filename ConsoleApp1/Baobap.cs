using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Baobap : Strom
    {

        public Baobap(double a, double b)
        {
            polomer = a;
            vyyyyyska = b;
        }

        public override double objem

        {
            get { return (Math.PI * (polomer * polomer) * vyyyyyska); }
        }
    }
}
