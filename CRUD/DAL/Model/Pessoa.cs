using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Pessoa
    {

        public int? Codigo { get; set; }

        public string Endereco { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }
        public int Cidade { get; set; }
        public string NomeCidade { get; set; }
        public int Estado { get; set; }
        public string NomeEstado{ get; set;}
        
    }
}
