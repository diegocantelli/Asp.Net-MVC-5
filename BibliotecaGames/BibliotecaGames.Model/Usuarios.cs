using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.Model
{
    public class Usuarios
    {
        private int _id;
        private string _login;
        private string _senha;
        private string _perfil;


        public string Perfil
        {
            get { return _perfil; }
            set { _perfil = value; }

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value;}
        }
    }
}
