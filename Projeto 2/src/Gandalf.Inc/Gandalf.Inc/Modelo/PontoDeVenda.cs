using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tbPos")]
    public class PontoDeVenda
    {
        [Key]
        public int fldPosID { get; set; }
        public virtual Loja fldStore { get; set; }
        public string fldStoreLocation { get; set; }
    }
}
