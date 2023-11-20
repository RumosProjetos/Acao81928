using System;
using System.Collections.Generic;
using System.IO;
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


        //Outra forma de calcular esse valor, poderia ter sido feita com LINQ
        private decimal CalcularValorTotalLinq()
        {
            decimal resultado = Items.Sum(x => x.Quantidade * x.Produto.PrecoUnitario);          
            return resultado;
        }


        public bool ValidarVenda()
        {
            bool resultado = true;

            if(Vendedor == null || Cliente == null || Items == null || PercentualDesconto >= 100)
            {
                resultado = false;
            }

            return resultado;
        }

        public void ImprimirRecibo()
        {
            if(ValidarVenda() == false)
            {
                Console.WriteLine("Venda ainda por finalizar");
            }
            else
            {
                string caminho = @"c:\temp\recibos\";

                if(Directory.Exists(caminho) == false)
                {
                    Directory.CreateDirectory(caminho);
                }

                string nomeArquivo = Cliente.Nome + string.Format("{0:_ddMMyyyy_HHmmss}", DateTime.Now);
                string caminhoCompleto = caminho + nomeArquivo + ".txt";

                StringBuilder sb = new StringBuilder();
                var separador = "";
                for (int i = 0; i < 80; i++)
                {
                    separador += "-";
                }

                sb.AppendLine(separador);
                sb.AppendLine("Gandalf.Inc" + "\t" + DataHoraVenda);
                sb.AppendLine(separador);
                sb.AppendLine("Cliente: " + Cliente.Nome);
                sb.AppendLine("Vendedor: " + Vendedor.Nome);
                sb.AppendLine(separador);


                sb.AppendLine("Nome Produto \t Valor Unitario \t Quantidade \t Total");
                foreach (Item item in Items)
                {
                    sb.AppendLine(item.Produto.Nome + "\t" + item.Produto.PrecoUnitario + "\t" + item.Quantidade + "\t" + item.PrecoItem);
                }

                sb.AppendLine(separador);
                sb.AppendLine("Total da Nota" + ValorFinal);

                File.AppendAllText(caminhoCompleto, sb.ToString());
            }
        }
    }
}
