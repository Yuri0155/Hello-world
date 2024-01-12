using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Strom : IOrganizmus
    {
        public Strom() { }

        public double vyska;
        public double polomer;

        public virtual double objem

        {
            get { return ((1.0 / 3.0) * Math.PI * (polomer * polomer) * vyska); }
        }
        public virtual void Rastie()
        {

        }

    }

}
