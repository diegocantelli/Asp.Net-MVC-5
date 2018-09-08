using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Model;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL.Persistence
{
    public class FornecedorDAL:Conexao
    {
        private string _Sql;
        public bool Inserir(Fornecedor modelo)
        {
           _Sql = "insert into fornecedores(Fantasia, email, cnpj) " +
                   "values(@fantasia, @email, @cnpj)";
            bool Sucesso = false;

            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(_Sql, Con);
                Cmd.Parameters.AddWithValue("@fantasia", modelo.Fantasia);
                Cmd.Parameters.AddWithValue("@email", modelo.Email);
                Cmd.Parameters.AddWithValue("@cnpj", modelo.Cnpj);
                Cmd.ExecuteNonQuery();
                Sucesso = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Fornecedor. Erro: "+ex.Message);
            }

            return Sucesso; 
        }

        public bool Excluir(int id)
        {
            
            string sql = " delete from fornecedores where id_fornecedor = @id_fornecedor ";
            bool Sucesso=true;
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@id_fornecedor", id);
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Sucesso = false; 
                throw new Exception("Erro ao excluir fornecedor. Erro: "+ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return Sucesso;
        }

        public bool Editar(Fornecedor f)
        {
            bool Sucesso = true;
            string sql = "update fornecedores set Fantasia=@fantasia, email=@email, cnpj=@cnpj " +
                         " where id_fornecedor = @id_fornecedor";
            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@fantasia",f.Fantasia);
                Cmd.Parameters.AddWithValue("@email",f.Email);
                Cmd.Parameters.AddWithValue("@cnpj",f.Cnpj);
                Cmd.Parameters.AddWithValue("@id_fornecedor",f.Id);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Sucesso = false;
                throw new Exception("Erro ao editar fornecedor. Erro: "+ex.Message);               
            }
            finally
            {
                Desconectar();
            }
            return Sucesso;
        }

        public List<Fornecedor> BuscaFornecedores()
        {
            string sql = "select * from fornecedores";
            List<Fornecedor> lista = null;

            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Dr = Cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    lista = new List<Fornecedor>();
                    while (Dr.Read())
                    {
                        Fornecedor f = new Fornecedor();
                        f.Id = Convert.ToInt32(Dr["id_fornecedor"]);
                        f.Fantasia = Dr["Fantasia"].ToString();
                        f.Email = Dr["Email"].ToString();
                        f.Cnpj = Dr["Cnpj"].ToString();
                        lista.Add(f);
                    }
                 }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao realizar consulta de fornecedores !"+ex.Message);
            }
            return lista;
        }

        public Fornecedor BuscaFornecedorId(int Id)
        {
            string sql = "select * from fornecedores where 1=1 and id_fornecedor=@id_fornecedor";
            Fornecedor f=null;

            try
            {
                AbrirConexao();
                Cmd = new MySqlCommand(sql, Con);
                Cmd.Parameters.AddWithValue("@id_fornecedor", Id);
                Dr = Cmd.ExecuteReader();

                if (Dr.HasRows)
                {
                    if (Dr.Read())
                    {
                        f = new Fornecedor();
                        f.Id = Convert.ToInt32(Dr["id_fornecedor"]);
                        f.Fantasia = Dr["Fantasia"].ToString();
                        f.Email = Dr["email"].ToString();
                        f.Cnpj = Dr["cnpj"].ToString();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar fornecedor por id. "+ex.Message);
            }
            finally
            {
                Desconectar();
            }
            return f;
        }
    
    }
}
