using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaGames.BLL;
using BibliotecaGames.BLL.Exceptions;
using BibliotecaGames.Model;
using System.Web.Security;

namespace BibliotecaGames.Site.Autenticacao
{
    public partial class Login : System.Web.UI.Page
    {
        private LoginBo _loginBo;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogar_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text;
            string senha = txtSenha.Text;

            _loginBo = new LoginBo();
            

            try
            {
                Usuarios u = _loginBo.UsuarioCadastrado(login, senha);
                FormsAuthentication.RedirectFromLoginPage(login, false);
            }
            catch (UsuarioNaoCadastradoException)
            {
                lblUserNaoEncontrado.Text = "Usuário não encontrado";
            }
            catch (Exception)
            {
                lblUserNaoEncontrado.Text = "Ocorreu um erro inesperado";
                throw;
            }
        }
    }
}