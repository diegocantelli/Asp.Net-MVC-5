using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ManipulaXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xDoc;
        string path;
        List<Pessoas> p = null;
        int indice,ultimo;
        CarregaXML xml;


        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                 xml = new CarregaXML(ofd.FileName);
                indice = xml.TamanhoLista();
                ultimo = indice-1;
                lblQtd.Text = indice.ToString();
                p = xml.RetornaListaPessoas();
            }

            ExibeXml(p.First());
        }

        
        private void btnSalvarSML_Click(object sender, EventArgs e)
        {
            XmlNodeList nodeNome = xml.RetornaNodes("Pessoas/Cliente/Nome");
            XmlNodeList nodeIdade = xml.RetornaNodes("Pessoas/Cliente/Idade");

            nodeNome[indice].InnerText = txtNome.Text;
            nodeIdade[indice].InnerText = txtIdade.Text;

            xml.Salvar();

        }

        private void ExibeXml(Pessoas pessoa)
        {            
            txtIdade.Text = pessoa.Idade.ToString();
            txtNome.Text = pessoa.Nome;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Anterior()
        {
            if (indice > 0)
            {
                Pessoas pessoa = p[indice - 1];
                ExibeXml(pessoa);
                indice--;
            }else
            {
                MessageBox.Show("Você já chegou no início do arquivo XML");
                
            }
        }

        private void Proximo()
        {
            if (indice < ultimo)
            {
                Pessoas pessoa = p[indice + 1];
                ExibeXml(pessoa);
                indice++;
            }
            else
            {
                MessageBox.Show("Você já chegou ao limite do arquivo XML");
            }
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            Anterior();   
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Proximo();
        }
    }
}
