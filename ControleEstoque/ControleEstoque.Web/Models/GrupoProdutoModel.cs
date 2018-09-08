using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace ControleEstoque.Web.Models
{
    public class GrupoProdutoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o nome.")]
        public string Nome { get; set; }

        public bool Ativo { get; set; }
        public static GrupoProdutoModel RecuperarPeloId(int id)
        {
            GrupoProdutoModel ret = null;

            using (var conexao = new MySqlConnection())
            {
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["principal"].ConnectionString;
                conexao.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "select * from grupo_produto where id = @id";
                    comando.Parameters.AddWithValue("@id", id);

                    var reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        ret = new GrupoProdutoModel
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = Convert.ToString(reader["nome"]),
                            Ativo = Convert.ToInt32(reader["ativo"]) == 1 ? true : false
                        };
                    }

                }
            }
            return ret;
        }

        public static bool ExcluirPeloId(int id)
        {
            var ret = false;

            using (var conexao = new MySqlConnection())
            {
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["principal"].ConnectionString;
                conexao.Open();

                if (RecuperarPeloId(id) != null)
                {
                    using (var comando = new MySqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "delete from grupo_produto where id = @id";
                        comando.Parameters.AddWithValue("@id", id);
                        ret = (comando.ExecuteNonQuery() > 0);
                    }
                }
            }
            return ret;
        }

        public int Salvar()
        {
            var ret = 0;
            var model = RecuperarPeloId(this.Id);



            using (var conexao = new MySqlConnection())
            {
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["principal"].ConnectionString;
                conexao.Open();

                using (var comando = new MySqlCommand())
                {
                    if (model == null)
                    {

                        comando.Connection = conexao;
                        comando.CommandText = "insert into grupo_produto(nome,ativo) values (@nome, @ativo); select last_insert_id() ";
                        comando.Parameters.AddWithValue("@nome", this.Nome);
                        comando.Parameters.AddWithValue("@ativo", this.Ativo ? 1 : 0);
                        ret = (int)comando.ExecuteScalar();
                    }
                    else
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "update grupo_produto set nome =@nome, ativo= @ativo where id = @id";
                        comando.Parameters.AddWithValue("@nome", this.Nome);
                        comando.Parameters.AddWithValue("@ativo", this.Ativo ? 1 : 0);
                        comando.Parameters.AddWithValue("@id", this.Id);
                        if(comando.ExecuteNonQuery() > 0)
                        {
                            ret = this.Id;
                        }
                    }
                }

            }
            return ret;
        }
        public static List<GrupoProdutoModel> RecuperarLista()
        {
            var ret = new List<GrupoProdutoModel>();
            MySqlDataReader reader;

            using (var conexao = new MySqlConnection())
            {
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["principal"].ConnectionString;
                conexao.Open();

                using (var comando = new MySqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = "select * from grupo_produto order by nome";

                    reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        ret.Add(new GrupoProdutoModel
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nome = Convert.ToString(reader["nome"]),
                            Ativo = Convert.ToInt32(reader["ativo"]) == 1 ? true : false
                        });
                    }

                }
            }
            return ret;
        }
    }
}