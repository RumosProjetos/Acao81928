using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblPagamentos")]
    public class Pagamento
    {
        [Column(name: "fldIdPagamento")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public virtual Venda Venda { get; set; }

        [Range(0, double.MaxValue)]
        public decimal ValorPago { get; set; }

        public virtual TipoPagamento TipoPagamento { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual Loja Loja { get; set; }
    }
}
