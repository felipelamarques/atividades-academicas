using System.Reflection.Metadata;

namespace Banco
{
    public class TB1
    {
        //Dll de conexão e manipulação de dados
        public bool InserirNome(String nome)
        {
            bool ret = false;

            String strcnx = "Data Source=MLB2;Initial Cataolg=DB1;Integrated Security=True";
            String Query = "INSET INTO TB1(Nome)VALUES('"+nome+"')";

            SqlConnection cnx = new SqlConnection(strcnx);
            SqlCommand cmd = new SqlCommand(Query, cnx);

            cnx.Open();
            cnx.ExecuteNonQuery();
            cnx.Close();

            ret = true;

            return ret;
        }
    }
}
