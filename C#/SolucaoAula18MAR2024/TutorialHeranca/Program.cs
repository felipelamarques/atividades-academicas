using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialHeranca
{
    class Avo
    {
        public Avo() { Console.WriteLine("AVO"); }
    }

    class Mae:Avo
    {
        public Mae() { Console.WriteLine("Mae"); }
    }

    class Filha:Mae
    {
        public Filha() { Console.WriteLine("Filha"); }
    }

    class Neta:Filha
    {
        public Neta() { Console.WriteLine("Neta"); }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Avo A = new Avo();
            Mae M = new Mae();
            Filha F = new Filha();
            Neta N = new Neta();

        }
    }
}
