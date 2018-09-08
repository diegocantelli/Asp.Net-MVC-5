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
    public partial class CadastroFornecedores : System.Web.UI.Page
    {
        private int _id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
                if (Session["FornecedorModel"] != null)//possui um objeto de cliente para edição
                {
                    CarregaDadosPagina();
                }
        }

        public void AbreCliente(int Id)
        {
            _id = Id;
        }

       
        private void Inserir()
        {
            Fornecedor modelo = new Fornecedor();
            FornecedorDAL dal = new FornecedorDAL();
            PreencheModelo(modelo);
            if (dal.Inserir(modelo))
                lblMensagem.Text = "Fornecedor inserido com sucesso !";
            else
                lblMensagem.Text = "Erro ao inserir fornecedor !";
            
        }

        private void Editar()
        {
            // todo testar método editar
            Fornecedor modelo = (Fornecedor) Session["FornecedorModel"];
            FornecedorDAL dal = new FornecedorDAL();
            
            if (dal.Editar(modelo))
                lblMensagem.Text = "Fornecedor alterado com sucesso !";
            else
                lblMensagem.Text = "Erro ao alterar fornecedor !";
            Session["FornecedorModel"] = null;
        }

        private void CarregaDadosPagina()
        {
            if(Session["FornecedorModel"] != null)
            {
                Fornecedor f = (Fornecedor)Session["FornecedorModel"];
                txtId.Text       = Convert.ToString(f.Id);
                txtFantasia.Text = f.Fantasia;
                txtEmail.Text    = f.Email;
                txtCnpj.Text     = f.Cnpj;                
            }
            
        }

        private void CarregaCampos(Fornecedor f)
        {
            txtId.Text = Convert.ToString(f.Id);
            txtFantasia.Text = f.Fantasia;
            txtEmail.Text = f.Email;
            txtCnpj.Text = f.Cnpj;
        }

        private void PreencheModelo(Fornecedor modelo)
        {
            modelo.Fantasia = txtFantasia.Text;
            modelo.Email    = txtEmail.Text;
            modelo.Cnpj     = txtCnpj.Text;
        }

        protected void btnGravarFornecedor(object sender, EventArgs e)
        {
            if (Session["FornecedorModel"] != null)
            {
                Fornecedor f = (Fornecedor)Session["FornecedorModel"];
                PreencheModelo(f);
                Session["FornecedorModel"] = f;
                Editar();
            }
            else
            {
                Inserir();
            }
                     

        }
    }
}