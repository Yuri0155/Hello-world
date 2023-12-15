using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Strom
    {
        public Strom() { }

        public double vyyyyyska;
        public double polomer;

        public virtual double objem

        {
            get { return ((1.0 / 3.0) * Math.PI * (polomer * polomer) * vyyyyyska); }
        }

    }

}
