using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGames.Model;
using MySql.Data.MySqlClient;

namespace BibliotecaGames.DAL
{
    public class UsuarioDao
    {
        public Usuarios ObterUsuarioESenha(string usuario, string senha)
        {
            try
            {
               
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = Conexao.con;
                comando.CommandText = "select * from usuarios where login = @login and senha = @senha";
                comando.Parameters.AddWithValue("@login", usuario);
                comando.Parameters.AddWithValue("@senha", senha);

                Conexao.Conectar();

                MySqlDataReader reader = comando.ExecuteReader();

                Usuarios u = null;

                while (reader.Read())
                {
                    u = new Usuarios();
                    u.Id = Convert.ToInt32(reader["id_usuario"]);
                    u.Login = Convert.ToString(reader["Login"]);
                    u.Perfil =Convert.ToString(reader["perfil"]);
                    u.Senha = Convert.ToString(reader["senha"]);
                }

                return u;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Conexao.Desconectar();
            }
        }
    }
}
