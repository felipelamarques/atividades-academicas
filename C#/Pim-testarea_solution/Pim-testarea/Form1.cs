using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_testarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            //string server = "PC-B450M";  // Pode ser um endereço IP ou o nome do servidor
            //string serverdoor = "8391";
            //string database = "ampereti_db";
            //string username = "sa";
            //string password = "Admin1234";

            // Defina a string de conexão com os detalhes do seu servidor SQL e banco de dados.
            string connectionString = "Server=PC-B450M;Database=ampereti_db;User Id=sa;Password=Admin1234;";

            // Cria uma conexão com o banco de dados.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Abre a conexão com o banco de dados.
                    connection.Open();
                    Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");

                    // Aqui você pode executar consultas, comandos, etc.
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
        }// A conexão é fechada automaticamente ao sair do bloco 'using'.
    }
}

