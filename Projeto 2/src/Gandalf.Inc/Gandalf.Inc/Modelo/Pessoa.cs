using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public abstract class Pessoa
    {
        public abstract int Id { get; set; } //abstract : Tem que ser implementado
        public virtual string Nome { get; set; } //virtual: Pode ser sobrescrito
        public virtual string Endereco { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Email { get; set; }
    }
}
