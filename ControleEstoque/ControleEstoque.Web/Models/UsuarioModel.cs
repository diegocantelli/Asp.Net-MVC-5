using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            bool ret = false;
            using (var conexao = new MySqlConnection())
            {
                conexao.ConnectionString = "server=localhost;user id=root; password=cursomysql; database=controle_estoque; SslMode=none";
                conexao.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "select count(*) from usuario where login = @login and senha = @senha ";
                    comando.Parameters.AddWithValue("@login", login);
                    comando.Parameters.AddWithValue("@senha", senha);
                    
                    ret = (Convert.ToInt32(comando.ExecuteScalar()) > 0);
                }
            }
            return ret;
        }        
    }
}