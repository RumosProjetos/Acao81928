using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblClientes")]
    public class Cliente : Pessoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Identificação do Cliente")]
        public override int Id { get; set; }


        [MaxLength(60)]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome do Cliente")]
        public override string Nome { get; set; }

        [MaxLength(120)]
        public override string Endereco { get; set; }

        [MaxLength(50)]
        public override string Cidade { get; set; }

        [MaxLength(250)]
        [EmailAddress]
        public override string Email { get; set; }

        [MaxLength(9)]
        [Required]
        [Display(Name = "NIF")]
        public string NumeroIdentificacaoFiscal { get; set; }

        public virtual ICollection<Venda> Vendas { get; set; }

    }
}
