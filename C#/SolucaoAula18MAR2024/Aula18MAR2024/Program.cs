using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula18MAR2024
{
    internal class Program
    {
        class animal
        {
            public bool Cao()
            {
                //Code
            }
            public bool Gato()
            {
                //Code
            }
        }
        class MaquinaAlimentar
        {
            public bool Alimentar(Alimentacao animal)
            {
                animal.Comer('Golden');
                return true;
            }
        }
        
        static void Main(string[] args)
        {
            Cao c1 = new Cao();
            Gato g1 = new Gato();
            MaquinaAlimentar m1 = new MaquinaAlimentar();
            m1.Alimentar(c1);
            m1.Alimentar(g1);

        }
    }
}
