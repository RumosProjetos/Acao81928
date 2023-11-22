using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gandalf.Inc.Modelo
{
    [Table(name: "tblVendas")]
    public class Venda
    {
        public int Id { get; set; }
        public string NumeroFatura { get; set; }
        public int NumeroPontoDeVenda { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificacao { get; set; }
        public bool Pago { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual PontoDeVenda PontoDeVenda { get; set; }
        public virtual Loja Loja { get; set; }
    }
}