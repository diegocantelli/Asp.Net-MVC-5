using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Persistence;
using DAL.Model;

namespace Site.Pages
{
    public partial class ConsultaFornecedores : System.Web.UI.Page
    {

        protected void CarregaGrid()
        {
            FornecedorDAL dal = new FornecedorDAL();
            GridFornecedores.DataSource = dal.BuscaFornecedores();
            GridFornecedores.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        protected void Editar(int id)
        {
            CadastroFornecedores cad = new CadastroFornecedores();
            FornecedorDAL dal = new FornecedorDAL();
            Fornecedor f = dal.BuscaFornecedorId(id);
            if (f != null)
                Session["FornecedorModel"] = f;
            Response.Redirect("CadastroFornecedores.aspx");
        }

        protected void Excluir(int id)
        {
            FornecedorDAL dal = new FornecedorDAL();
            if (dal.Excluir(id))
                lblMensagem.Text = "Fornecedor excluído com sucesso";
            else
                lblMensagem.Text = "Erro ao excluir fornecedor";
            CarregaGrid();
        }

        protected void EdicaoCliente(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Editar":
                    Editar(Convert.ToInt32(e.CommandArgument));
                    break;
                case "Excluir":
                    Excluir(Convert.ToInt32(e.CommandArgument));
                    break;
                default:
                    break;
            }
        }
    }
}