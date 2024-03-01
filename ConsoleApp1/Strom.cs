using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal abstract class Strom : IOrganizmus
    {
        public Strom()
        {
            Dictionary<Coordinate, Vetva> vetvy = new Dictionary<Coordinate, Vetva>();
            Vetva v1 = new Vetva(0, 0);
            Coordinate c1 = new Coordinate(30, 40, 50, 10);
            vetvy.Add(c1,v1);
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
            if (vek > 2)
            {
                vyska = vyska + cas * 5;
                polomer = polomer + cas * 2;
                
            }
        }
    }
}
