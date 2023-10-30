using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public class Item
    {
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public decimal PrecoItem => Quantidade * Produto.PrecoUnitario;
    }
}
