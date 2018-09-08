using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.Model
{
    public class Editor
    {
        private int _id;
        private string _nome;
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Nome
        {
            get { return this._nome; }
            set { this._nome = value; }
        }


    }
}
