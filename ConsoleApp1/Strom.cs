using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Strom : IOrganizmus
    {
        public Strom(){
            List<Vetva> vetvy = new List<Vetva>();
            Vetva v1 = new Vetva(0,0);
            vetvy.Add(v1);
        }

        public double vyska;
        public double polomer;
        public double vek;
        

        public virtual double objem

        {
            get { return ((1.0 / 3.0) * Math.PI * (polomer * polomer) * vyska); }
        }
        public virtual void Rastie(double cas)
        {
            if(vek > 2 )
            {
                vyska = vyska + cas * 5;
                polomer = polomer + cas * 2;
            }

        }

    }

}
