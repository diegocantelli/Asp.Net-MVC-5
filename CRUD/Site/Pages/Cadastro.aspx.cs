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
    public partial class Cadastro : System.Web.UI.Page
    {
        private Pessoa p;
         
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
                if (Session["ClienteModel"] != null)//possui um objeto de cliente para edição
                { 
                    CarregaCliente();
                    CarregaCombos();
                }
                
                    
             


        }

        private void CarregaCombos()
        {
            PessoaDAL dal = new PessoaDAL();
            ddlEstado.DataSource = dal.ListarEstados();
            ddlEstado.DataBind();
        }

        
        protected void NovoCliente()
        {
            try
            {
                p = new Pessoa();
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;
                p.Estado = Convert.ToInt32(ddlEstado.SelectedValue);

                PessoaDAL pdal = new PessoaDAL();
                pdal.Gravar(p);

                lblMensagem.Text = "CLiente cadastrado com sucesso !";

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao cadastrar usuário" + ex.Message);
            }
        }

        
        protected void AlterarCliente()
        {
            try
            {
                PessoaDAL pdal = new PessoaDAL();
                p = (Pessoa)Session["ClienteModel"];
                p.Nome = txtNome.Text;
                p.Endereco = txtEndereco.Text;
                p.Email = txtEmail.Text;
                p.Estado = Convert.ToInt32(ddlEstado.SelectedValue);
                pdal.Atualizar(p);
                Session["ClienteModel"] = null;
                lblMensagem.Text = "CLiente alterado com sucesso !";

                txtNome.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtEmail.Text = string.Empty;

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao alterar usuário" + ex.Message);
            }
        }

        protected void CarregaCliente()
        {
            try
            {
                p = (Pessoa)Session["ClienteModel"];
                txtNome.Text = p.Nome;
                txtEndereco.Text = p.Endereco;
                txtEmail.Text = p.Email;
                ddlEstado.SelectedValue = p.Estado.ToString();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao alterar usuário" + ex.Message);
            }
        }

        protected void btnCadastrarCliente(object sender, EventArgs e)
        {
            if (Session["ClienteModel"] == null)
            {
                NovoCliente();
            }else
            {
                AlterarCliente();
            }
        }
    }
}