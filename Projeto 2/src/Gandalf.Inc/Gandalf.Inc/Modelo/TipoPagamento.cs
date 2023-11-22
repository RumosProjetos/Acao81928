using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblPaymentType")]
    public class TipoPagamento
    {
        [Key]
        public int fldPaymentTypeID { get; set; }
        [MaxLength(50)]
        public string fldPaymentType { get; set; }
    }
}