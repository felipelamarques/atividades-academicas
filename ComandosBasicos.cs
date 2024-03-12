using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandosBasicos
{
    internal class Program
    {
        class Cliente
        {
            public int ID { get; set; }
            public int _id;
            public void set_id(int id) {this._id = id; }
            public int Get_id() {return _id; }
        }

        class Cliente2
        {
            public int ID2
            {
                get{ return ID2; }
                set{ ID2 = value; }
            }
        }
        static void Main(string[] args)
        {
            Cliente cli = new Cliente();
            cli.ID =1 ;
            Console.WriteLine(cli.ID);
            cli._id =3 ;
            Console.WriteLine(cli._id);
        }
    }
}
