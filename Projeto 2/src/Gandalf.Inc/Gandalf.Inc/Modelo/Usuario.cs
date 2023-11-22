using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblUsuarios")]
    public class Usuario : Pessoa //Utilizador
    {
        [Display(Name = "Id do usuário no Ponto de Venda")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(name: "fldId")]
        public override int Id { get; set; }

        [MaxLength(60)]
        [Required(ErrorMessage = "Nome é obrigatório")]
        [Column(name: "fldNomeUsuario")]
        public override string Nome { get; set; }

        [Column(name: "fldNumeroUsuario")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumeroUser { get; set; }

        [MaxLength(50)]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [MaxLength(120)]
        [Column(name: "Morada")]
        public override string Endereco { get; set; }

        [MaxLength(50)]
        public override string Cidade { get; set; }

        [EmailAddress]
        [MaxLength(250)]
        public override string Email { get; set; }

        [MaxLength(9)]
        [Phone]        
        public string Telefone { get; set; }
    }
}
