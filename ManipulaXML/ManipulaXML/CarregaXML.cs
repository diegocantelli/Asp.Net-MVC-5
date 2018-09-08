using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ManipulaXML
{
    public class CarregaXML
    {
        private string _Path;
        public XmlDocument xDoc;
        private List<Pessoas> listPessoas = null;
        private int tamanhoLista = 0;

        public CarregaXML(string Path)
        {
            _Path = Path;
            xDoc = new XmlDocument();
            xDoc.Load(_Path);
            listPessoas = LerXML();
            tamanhoLista = TamanhoLista();
        }

        //todo verificar como ir para o próximo item da lista de pessoas

        public int TamanhoLista()
        {
            return listPessoas.Count;
        }

        public List<Pessoas> LerXML()
        {   
            Pessoas pessoa = null;
            XmlNodeList nodeList = xDoc.SelectNodes("Pessoas/Cliente");
            if (nodeList != null)
            {
                listPessoas = new List<Pessoas>();
                foreach (XmlNode nodePessoa in nodeList)
                {
                    pessoa = new Pessoas();
                    pessoa.Nome = nodePessoa["Nome"].InnerText;
                    pessoa.Idade = Convert.ToInt32(nodePessoa["Idade"].InnerText);
                    listPessoas.Add(pessoa);
                }
            }
            return listPessoas;
        }

        public List<Pessoas> RetornaListaPessoas()
        {
            return listPessoas;
        }

        public XmlNodeList RetornaNodes(string node)
        {
            //Pessoas / Cliente / Nome
            return xDoc.SelectNodes(node);
        }

        public void Salvar()
        {
            xDoc.Save(_Path);
        }
    }
}
