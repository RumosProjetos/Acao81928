using Gandalf.Inc.Modelo;
using System;
using System.Linq;

namespace Gandalf.Inc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PosContext ctx = new PosContext();

            Usuario vendedor = new Usuario
            {
                Nome = "Vendedor",
                Cidade = "Porto",
                Email = "vendedor@gmail.com",
                Endereco = "Rua do Porto",
                Senha = "123456",
                Telefone = "123456789",
                NumeroUser = 1
            };

            ctx.Usuarios.Add(vendedor);
            ctx.SaveChanges();
            var vendedorRecemCriado = ctx.Usuarios.FirstOrDefault(u => u.Nome == vendedor.Nome);


            Cliente cliente = new Cliente
            {
                Nome = "João da Silva",
                NumeroIdentificacaoFiscal = "123456789",
                Email = "joao.silva@gmail.com",
                Cidade = "Lisboa",
                Endereco = "Rua de Lisboa"
            };
            ctx.Clientes.Add(cliente);
            ctx.SaveChanges();
            var clienteRecemCriado = ctx.Clientes.FirstOrDefault(u => u.Nome == cliente.Nome);


            Venda venda = new Venda
            {
                DataCriacao = DateTime.Now,
                NumeroFatura = "100",
                NumeroPontoDeVenda = 1,
                Pago = true,
                Usuario = vendedorRecemCriado,
                Cliente = clienteRecemCriado
            };

            ctx.Vendas.Add(venda);
            ctx.SaveChanges();
        }


        void CriarUsuario()
        {
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

        void AlterarUsuario(string nomeAntigo, string nomeNovo)
        {
            PosContext ctx = new PosContext();
            //Cliente joao = ctx.Clientes.Find(1);
            Cliente cliente = ctx.Clientes.FirstOrDefault(c => c.Nome == nomeAntigo);
            cliente.Nome = nomeNovo;
            ctx.SaveChanges();
        }

        void ApagarUsuario(string nome)
        {
            PosContext ctx = new PosContext();

            Cliente joao = ctx.Clientes.FirstOrDefault(c => c.Nome == "João da Silva");
            ctx.Remove(joao);

            ctx.SaveChanges();
        }


        Usuario BuscarUsuarioPeloNome(string nome)
        {
            PosContext ctx = new PosContext();
            return ctx.Usuarios.FirstOrDefault(u => u.Nome == nome);
        }
    }
}
