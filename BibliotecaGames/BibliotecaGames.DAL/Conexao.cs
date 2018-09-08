using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace BibliotecaGames.DAL
{
    public  class Conexao
    {
        public static string conectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexaoMySQl"].ConnectionString.ToString();
        public static MySqlConnection con = new MySqlConnection(conectionString);
        public static void Conectar()
        {           
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public static void Desconectar()
        {            
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
