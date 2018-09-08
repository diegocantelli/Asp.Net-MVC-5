using BibliotecaGames.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.DAL
{
    public class JogosDao
    {
        public List<Jogo> ObterTodososJogos()
        {
            try
            {
                var comando = new MySqlCommand();
                comando.Connection = Conexao.con;
                comando.CommandText = "select * from jogos";

                Conexao.Conectar();

                var reader = comando.ExecuteReader();

                var Jogos = new List<Jogo>();

                while (reader.Read())
                {
                    var jogo = new Jogo();
                    jogo.Id = Convert.ToInt32(reader["id"]);
                    jogo.Imagem = reader["imagem"].ToString();
                    jogo.Titulo = reader["titulo"].ToString();
                    jogo.Data = reader["data_compra"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["data_compra"]);
                    jogo.ValorPago = reader["valor_pago"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["valor_pago"]);

                    Jogos.Add(jogo);

                }

                return Jogos;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
