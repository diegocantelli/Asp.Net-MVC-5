using BibliotecaGames.DAL;
using BibliotecaGames.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaGames.BLL
{
    public class JogoBo
    {
        private JogosDao _jogoDao;

        public List<Jogo> ObterTodosOsJogos()
        {
            _jogoDao = new JogosDao();
            return _jogoDao.ObterTodososJogos();

        }
    }
}
