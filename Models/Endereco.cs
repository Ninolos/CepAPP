using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CepApp.Models
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }

    }
}
