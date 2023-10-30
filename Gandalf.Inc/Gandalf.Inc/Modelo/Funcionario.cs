using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Modelo
{
    public class Funcionario : Pessoa
    {
        public string NumeroSegurancaSocial { get; set; }
        public string NumeroFuncionario { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }


        public override void SalvarParaTexto()
        {
            string caminho = @"c:\temp\pessoa.txt";
            string espacador = "";

            for (int i = 0; i < 80; i++)
            {
                espacador += "-";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(espacador);
            sb.AppendLine("Nome : " + Nome);
            sb.AppendLine("NumeroIdentidadeFiscal : " + NumeroIdentidadeFiscal);
            sb.AppendLine("DataNascimento : " + DataNascimento);
            sb.AppendLine("DataRegistro : " + DataRegistro);
            sb.AppendLine("NumeroSegurancaSocial : " + NumeroSegurancaSocial);
            sb.AppendLine("NumeroFuncionario : " + NumeroFuncionario);
            sb.AppendLine("Login : " + Login);
            sb.AppendLine("Password : " + Password);

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
