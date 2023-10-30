using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string NumeroIdentidadeFiscal { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataRegistro => DateTime.Now;
        public Morada Morada { get; set; }


        public virtual void SalvarParaTexto()
        {
            string caminho = @"c:\temp\pessoa.txt";

            StringBuilder sb = new StringBuilder();
            string espacador = "";

            for (int i = 0; i < 80; i++)
            {
                espacador += "-";
            }

            sb.AppendLine(espacador);
            sb.AppendLine("Nome : " + Nome);
            sb.AppendLine("NumeroIdentidadeFiscal : " + NumeroIdentidadeFiscal);
            sb.AppendLine("DataNascimento : " + DataNascimento);
            sb.AppendLine("DataRegistro : " + DataRegistro);

            if (Morada != null)
            {
                sb.AppendLine("Morada: ");
                sb.AppendLine("--------------------------------------------");
                sb.AppendLine("Distrito : " + Morada.Distrito);
                sb.AppendLine("Concelho : " + Morada.Concelho);
                sb.AppendLine("Codigo Postal : " + Morada.CodigoPostal + "-" + Morada.CodigoPostalComplemento);
                sb.AppendLine("Rua : " + Morada.Rua);
                sb.AppendLine("Número de Porta : " + Morada.NumeroPorta);
            }
            else
            {
                sb.AppendLine("Morada: Não Informada");
            }

            File.AppendAllText(caminho, sb.ToString());
        }
    }
}