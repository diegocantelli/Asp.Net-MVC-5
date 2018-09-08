using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using MySql.Data.MySqlClient;

namespace DAL.Persistence
{
    public class LoginDAL:Conexao
    {
        public bool Logar(Acesso l)
        {
            bool Sucesso = false;

            string _sql = "select * from login where login=@login and senha = @senha";
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(_sql, Con);
                Cmd.Parameters.AddWithValue("@login", l.Usuario);
                Cmd.Parameters.AddWithValue("@senha", l.Senha);
                Dr = Cmd.ExecuteReader();

                Sucesso = Dr.HasRows;
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Desconectar();
            }
            
            return Sucesso;
        }
    }
}
