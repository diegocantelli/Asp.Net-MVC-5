using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaGames.Model;
using BibliotecaGames.BLL;

namespace BibliotecaGames.Site.Jogos
{
    public partial class Catalogo : System.Web.UI.Page
    {
        private JogoBo _jogosBo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarJogosNoRepeater();
            }
            
        }

        private void CarregarJogosNoRepeater()
        {
            _jogosBo = new JogoBo();
            RepeaterJogos.DataSource = _jogosBo.ObterTodosOsJogos(); 
            RepeaterJogos.DataBind();
        }
    }
}