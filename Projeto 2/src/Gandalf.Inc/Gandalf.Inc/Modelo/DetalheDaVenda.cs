using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblSalesDetails")]
    public class DetalheDaVenda
    {
        [Column(name: "fldSalesDetailID")]
        public int Id { get; set; }

        public virtual Venda Venda { get; set; }
        public int SalesId { get; set; }
        public virtual Produto Produto { get; set; }

        public DateTime DataCriacao { get; set; }
    }
}
