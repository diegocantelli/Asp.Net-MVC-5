using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL.Persistence
{
    public class PessoaDAL:Conexao
    {
       
        public void Gravar(Pessoa p)
        {
            string sql = "insert into cliente(nome, endereco, email, id_estado) " +
                         "values(@nome, @end, @email, @id_estado)";
            
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@nome", p.Nome);
                Cmd.Parameters.AddWithValue("@end", p.Endereco);
                Cmd.Parameters.AddWithValue("@email", p.Email);
                Cmd.Parameters.AddWithValue("@id_estado", p.Estado);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao inserir cliente. Erro: "+ex.Message);
            }
            finally
            {
                Desconectar();
            }

            
        }

        public Boolean Atualizar(Pessoa p)
        {
            string sql = "update cliente set nome = @nome, email = @email, endereco = @endereco, "
                        +" id_estado = @id_estado "
                        + " where id = @id";
            Boolean sucesso = false;
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@nome", p.Nome);
                Cmd.Parameters.AddWithValue("@email", p.Email);
                Cmd.Parameters.AddWithValue("@endereco", p.Endereco);
                Cmd.Parameters.AddWithValue("@id_estado", p.Estado);
                Cmd.Parameters.AddWithValue("@id", p.Codigo);
                Cmd.ExecuteNonQuery();
                sucesso = true;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao alterar dados do cliente. Erro: "+ex.Message);
            }
            finally
            {
                Desconectar();
            }

            return sucesso;
        }

        public Boolean Excluir(int? Id)
        {
            Boolean sucesso = false;
            string sql = "delete from cliente where id = @id";
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@id", Id);
                Cmd.ExecuteNonQuery();
                sucesso = true;
            }
            catch (Exception ex)
            {
                
                throw new Exception("Erro ao excluir Cliente. Erro: "+ex.Message);
                
            }
            finally
            {
                
                Desconectar();
                
            }

            return sucesso;
        }
        
        public Pessoa PesquisarPorCodigo(int codigo)
        {
            string sql = "select * from cliente where id= @id";
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@id", codigo);
                //Cmd.exe

                Dr = Cmd.ExecuteReader();

                Pessoa p = null;

                if (Dr.Read())
                {
                    p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["id"]);
                    p.Nome = (Dr["nome"]).ToString();
                    p.Email = (Dr["email"]).ToString();
                    p.Endereco = (Dr["endereco"]).ToString();
                    p.Estado = Convert.ToInt32(Dr["id_estado"]);
                }

                return p;

                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable ListarEstados()
        {
            string sql = "select * from estados";
            try
            {
                AbrirConexao();
                dt = new DataTable();
                Cmd = new MySqlCommand(sql, Con);
                da = new MySqlDataAdapter(Cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {

                throw;
            }

            return dt;
        }

        public List<Pessoa> Listar()
        {
            string sql = "select cli.id, cli.nome, cli.endereco, cli.email, "+
                         " est.id_estado, est.sigla "+
                         " from cliente cli " +
                         " left join estados est on (cli.id_estado = est.id_estado) where 1=1";
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Dr = Cmd.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (Dr.Read())
                {
                    Pessoa p = new Pessoa();
                    p.Codigo = Convert.ToInt32(Dr["id"]);
                    p.Nome = (Dr["nome"]).ToString();
                    p.Email = (Dr["email"]).ToString();
                    p.Endereco = (Dr["endereco"]).ToString();
                    p.NomeEstado = (Dr["sigla"]).ToString();

                    lista.Add(p);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar todos os clientes. Erro: "+ex.Message);
            }
            finally
            {
                Desconectar();
            }

           
        }
    }
}
