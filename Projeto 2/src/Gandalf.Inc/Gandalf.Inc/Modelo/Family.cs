using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblFamily")]
    public class Categoria
    {
        [Key]
        public int fldFamilyId { get; set; }
        public string fldFamily { get; set; }
    }
}