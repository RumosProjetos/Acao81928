using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblStocks")]
    public class Estoques
    {
        [Key]
        public int fldStockId { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Loja Loja { get; set; }
        public int Quantidade { get; set; }
        public int QuantidadeBase { get; set; }
        public string fldQtySaleUnit { get; set; }
        public DateTime DataModificacao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
