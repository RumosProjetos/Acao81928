using Gandalf.Inc.Modelo;
using System;

namespace Gandalf.Inc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PosContext ctx = new PosContext();
            Cliente joao = new Cliente
            {
                Nome = "João",
                NumeroIdentificacaoFiscal = "123456789",
                Email = "joao@gmail.com",
                Cidade = "Porto",
                Endereco = "Rua do Porto"
            };

            ctx.Clientes.Add(joao);
            ctx.SaveChanges();


        }
    }
}
