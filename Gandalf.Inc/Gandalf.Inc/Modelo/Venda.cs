using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public class Venda
    {
        public Cliente Cliente { get; set; }
        public Funcionario Vendedor { get; set; }
        public DateTime DataHoraVenda => DateTime.Now;
        public List<Item> Items { get; set; }
        public decimal ValorTotal => CalcularValorTotal();
        public decimal PercentualDesconto { get; set; }
        public decimal ValorFinal => ValorTotal * (1 - PercentualDesconto);


        private decimal CalcularValorTotal()
        {
            decimal resultado = 0;

            foreach (Item item in Items) {
                resultado += item.Quantidade * item.Produto.PrecoUnitario;
            }

            return resultado;
        }
    }
}
