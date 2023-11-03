using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public class Produto
    {
        public Guid Identificador { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }
}