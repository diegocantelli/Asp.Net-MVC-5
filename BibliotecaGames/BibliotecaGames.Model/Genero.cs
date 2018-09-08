using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.Model
{
    public class Genero
    {
        private int _id;
        private string _descricao;

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string Descricao
        {
            get { return this._descricao; }
            set { this._descricao = value; }
        }
    }
}
