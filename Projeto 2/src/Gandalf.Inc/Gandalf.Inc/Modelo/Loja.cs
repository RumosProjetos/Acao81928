using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public class Loja
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string EnderecoLoja { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataModificacao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
