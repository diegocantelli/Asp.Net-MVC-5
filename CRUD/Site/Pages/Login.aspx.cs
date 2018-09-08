using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;
using System.Web.Security;

namespace Site.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogar(object sender, EventArgs e)
        {
            Acesso acesso = new Acesso();
            LoginDAL dal = new LoginDAL();

            acesso.Usuario = txtLogin.Text;
            acesso.Senha = txtSenha.Text;

            if (dal.Logar(acesso))
            {
                FormsAuthentication.RedirectFromLoginPage(acesso.Usuario, true);
                Response.Redirect("Principal.aspx");
            }else
            {
                lblMensagem.Text = "Usuário não cadastrado.";
            }
            

        }
    }
}