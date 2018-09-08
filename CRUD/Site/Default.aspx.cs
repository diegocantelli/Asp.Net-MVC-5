using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Model;
using DAL.Persistence;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlDados.Visible = false;
        }

        protected void btnPesquisarCliente(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL dal = new PessoaDAL();
                Pessoa p = dal.PesquisarPorCodigo(Codigo);

                if (p != null)
                {
                    txtNome.Text = p.Nome;
                    txtEmail.Text = p.Email;
                    txtEndereco.Text = p.Endereco;
                    pnlDados.Visible = true;
                }else
                {
                    lblMensagem.Text = "Usuário não encontrado";
                }
                
            }
            catch (Exception ex)
            {

                lblMensagem.Text = "Erro. "+ex.Message;
            }
        }

        protected void btnExcuirCliente(object sender, EventArgs e)
        {
            PessoaDAL dal = new PessoaDAL();
            Pessoa p = new Pessoa();

            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            
            if (dal.Excluir(p.Codigo)){
                lblMensagem.Text = "Cliente excluído com sucesso";
            }
            else
            {
                lblMensagem.Text = "Erro ao excluir cliente";
            }

        }

        protected void btnAtualizarCliente(object sender, EventArgs e)
        {
            PessoaDAL dal = new PessoaDAL();
            Pessoa p = new Pessoa();

            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            p.Nome = txtNome.Text;
            p.Endereco = txtEndereco.Text;
            p.Email = txtEndereco.Text;

            if (dal.Atualizar(p))
            {
                lblMensagem.Text = "Cliente atualizado com sucesso";
            }
            else
            {
                lblMensagem.Text = "Erro ao atualiza cliente";
            }
        }
    }
}