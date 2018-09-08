using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL.Persistence
{
    public class Conexao
    {
        private string ConnStr = "server=localhost;user id = root;passworD=cursomysql; port=3306;"
                                +" database=CRUD; SslMode=none";

        protected MySqlConnection Con;
        protected MySqlCommand Cmd;
        protected MySqlDataReader Dr;
        protected DataTable dt;
        protected MySqlDataAdapter da;

        protected void AbrirConexao()
        {
            try
            {
                Con = new MySqlConnection(ConnStr);
                Con.Open();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar-se com o banco dados. Erro: "+ex.Message);
            }
           
        }

        protected void Desconectar()
        {
            Con.Close();
        }

    }
}
