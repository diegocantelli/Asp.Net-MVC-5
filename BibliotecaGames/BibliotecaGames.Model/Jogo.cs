using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.Model
{
    public class Jogo
    {
        private int _id;
        private double? _valorPago;
        private string _imagem;
        private DateTime? _data;
        private string _titulo;

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public double? ValorPago
        {
            get { return this._valorPago; }
            set { this._valorPago = value; }
        }

        public string Imagem
        {
            get { return this._imagem; }
            set { this._imagem = value; }
        }

        public DateTime? Data
        {
            get { return this._data; }
            set { this._data = value; }
        }
    }
}
