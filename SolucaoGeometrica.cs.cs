using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Program
    {
        class Figura
        {
            double Lado1;
            public void SetLado1(double lado1) { Lado1 = lado1; }
            public double GetLado1() { return Lado1; }

            double Lado2;
            public void SetLado2(double lado2) { Lado2 = lado2; }
            public double GetLado2() { return Lado2; }

            public double AreaR() { return Lado1 * Lado2; }
        }
        class Quadrado:Figura
        {
            double Lado;
            public void SetLado (double lado) { Lado = lado; }
            public double GetLado() {  return Lado; }

            public double AreaQ() { return Lado * Lado; }
        }

        class Retangulo:Figura
        {
            
        }
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado();
            Retangulo r1 = new Retangulo();
            q1.SetLado(3.5);
            r1.SetLado1(5.0); r1.SetLado2(4.0);
            //Console.WriteLine( "Lado = {0}", q1.GetLado() );
            Console.WriteLine( "Area Quadrado = {0}", q1.AreaQ() );
            Console.WriteLine( "Area Retangulo = {0}", r1.AreaR() );
        }
    }
}