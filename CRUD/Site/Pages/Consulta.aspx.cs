using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site.Pages
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                PessoaDAL dal = new PessoaDAL();
                GridClientes.DataSource = dal.Listar();
                GridClientes.DataBind();               
            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Erro ao buscar clientes. Erro: " + ex.Message;
            }

        }

        protected void acaoCart(object sender, GridViewCommandEventArgs e)
        {
            PessoaDAL dal = new PessoaDAL();
            Pessoa p = new Pessoa();
            if (e.CommandName == "Editar")
            {
                p = dal.PesquisarPorCodigo(Convert.ToInt32(e.CommandArgument));

                if (p != null)
                    Session["ClienteModel"] = p;

                Response.Redirect("~/Pages/Cadastro.aspx");
            }

            if (e.CommandName == "Excluir")
            {
                if (dal.Excluir(Convert.ToInt32(e.CommandArgument)))
                {
                    GridClientes.DataSource = dal.Listar();
                    GridClientes.DataBind();
                }
                else
                {
                    lblMensagem.Text = "Não foi possível excluir o cliente !";
                }
            }

        }

        
    }
}