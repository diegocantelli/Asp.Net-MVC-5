using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class Detalhe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcessar(object sender, EventArgs e)
        {
            string opcao = ddlMenu.SelectedValue;

            //todo implementar menu diferente
            switch (opcao)
            {
                case "0":
                    LblMensagem.Text = "Favor selecionar uma opção válida";
                    break;
                case "1":
                    Response.Redirect("/Pages/Cadastro.aspx");
                    break;
                case "2":
                    Response.Redirect("/Pages/Consulta.aspx");
                    break;
                case "3":
                    Response.Redirect("../Default.aspx");
                    break;
                case "4":
                    Response.Redirect("/Pages/CadastroFornecedores.aspx");
                    break;
                case "5":
                    Response.Redirect("/Pages/ConsultaFornecedores.aspx");
                    break;                
            }

        }
    }
}