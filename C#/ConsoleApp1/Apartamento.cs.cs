using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Apartamento
        {
            bool Piso;
            double Area;
            int Comodos;

            public Apartamento(bool piso) { piso = piso; }
            public Apartamento(double area, int comodos)
            {
                Area = area;
                Comodos = comodos;
            }

        }
        static void Main(string[] args)
        {
            Apartamento ap1 = new Apartamento(true);
            Apartamento ap2 = new Apartamento(127.5, 10);
        }
    }
}
