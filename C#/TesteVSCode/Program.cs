using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//using DLLRelVendas;

namespace RelatorioVendas
{
    internal class Program
    {
        class Relatorios
        {
            public bool Vendas(DateTime dte, DateTime dtf)
            {
                Console.WriteLine("Periodo");
                return true;
            }

            public bool Vendas(string catProd)
            {
                Console.WriteLine("Categoria Produto");
                return true;
            }

            public bool Vendas(int ano)
            {
                Console.WriteLine("Ano");
                return true;
            }
        }

        class Apartamento
        {
            bool Piso;
            double Area;
            int Comodos;

            public Apartamento(bool piso)
            {
                piso = Piso; 
            }

            public Apartamento() {}

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
            Apartamento ap3 = new Apartamento();

            Relatorios r1 = new Relatorios();
            r1.Vendas(DateTime.Now, DateTime.Now);
            r1.Vendas("Linha branca");
            r1.Vendas(2023);
        }
    }
}

