using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaGames.DAL;
using BibliotecaGames.Model;
using BibliotecaGames.BLL.Exceptions;

namespace BibliotecaGames.BLL
{
    public class LoginBo
    {
        private UsuarioDao _usuarioDao;

        public Usuarios UsuarioCadastrado(string login, string senha)
        {
            _usuarioDao = new UsuarioDao();
            Usuarios _usuario = _usuarioDao.ObterUsuarioESenha(login, senha);

            if (_usuario == null)
            {
                throw new UsuarioNaoCadastradoException();
            }else
            {
                return _usuario;
            }

        }
    }
}
