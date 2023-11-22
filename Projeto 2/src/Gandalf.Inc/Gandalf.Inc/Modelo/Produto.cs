using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblProduct")]
    public class Produto
    {
        [Key]
        public int fldProductId { get; set; }
        public string fldBarCode { get; set; }
        public string fldProductName { get; set; }
        public Categoria Categoria { get; set; }
        public string fldUnitMeasure { get; set; }
        public int fldQtyPerUnit { get; set; }
        public decimal fldUnitPrice { get; set; }
        public bool fldDiscontinued { get; set; }

        public DateTime fldDateCreated { get; set; }
        public DateTime fldDateModified { get; set; }
    }
}