using Gandalf.Inc.Modelo;
using System;

namespace Gandalf.Inc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gandalf.Inc");

            Cliente Maria = new Cliente();
            Maria.Nome = "Maria";
            Maria.NumeroIdentidadeFiscal = "123456789";
            Maria.DataNascimento = new DateTime(1980, 1, 1);
            Maria.Morada = new Morada();
            Maria.Morada.Distrito = "Porto";
            Maria.Morada.Concelho = "Porto";
            Maria.Morada.CodigoPostal = "4000";
            Maria.Morada.CodigoPostalComplemento = "123";
            Maria.Morada.Rua = "Rua do Porto";
            Maria.Morada.NumeroPorta = "123";
            Maria.SalvarParaTexto();


            Funcionario Joao = new Funcionario();
            Joao.Nome = "Joao";
            Joao.NumeroIdentidadeFiscal = "123456789";
            Joao.DataNascimento = new DateTime(1980, 1, 1);
            Joao.Morada = new Morada();
            Joao.Morada.Distrito = "Lisboa";
            Joao.Morada.Concelho = "Lisboa";
            Joao.Morada.CodigoPostal = "2000";
            Joao.Morada.CodigoPostalComplemento = "123";
            Joao.Morada.Rua = "Rua do Porto";
            Joao.Morada.NumeroPorta = "123";


            Joao.SalvarParaTexto();

        }
    }
}
