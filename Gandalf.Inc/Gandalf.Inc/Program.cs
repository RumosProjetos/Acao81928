using Gandalf.Inc.Modelo;
using System;
using System.Collections.Generic;

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


            Produto computador = new Produto
            {
                Marca = "IBM",
                Categoria = "PC",
                Nome = "Lentium",
                PrecoUnitario = 1000,
                QuantidadeEmEstoque = 10
            };

            Produto smartphone = new Produto
            {
                Categoria = "Smartphone",
                Marca = "Pineapple",
                Nome = "EuFoneX",
                PrecoUnitario = 1500,
                QuantidadeEmEstoque = 5
            };

            Produto impressora = new Produto
            {
                Categoria = "Impressora",
                Marca = "JP",
                Nome = "Impressora Laser",
                PrecoUnitario = 100,
                QuantidadeEmEstoque = 7
            };




            Estoque EstoqueDaLoja = new Estoque
            {
                Produtos = new List<Produto>()
            };

            EstoqueDaLoja.Produtos.Add(computador);
            EstoqueDaLoja.Produtos.Add(smartphone);
            EstoqueDaLoja.Produtos.Add(impressora);


            Venda carrinhoComprasMaria = new Venda();
            carrinhoComprasMaria.Cliente = Maria;
            carrinhoComprasMaria.Vendedor = Joao;
            carrinhoComprasMaria.Items = new List<Item>();

            Item item01 = new Item();
            item01.Produto = smartphone;
            item01.Quantidade = 2;

            carrinhoComprasMaria.Items.Add(item01);

            Item item02 = new Item();
            item02.Produto = computador;
            item02.Quantidade = 1;

            carrinhoComprasMaria.Items.Add(item02);

            carrinhoComprasMaria.PercentualDesconto = 0.10M;


            Console.WriteLine("Valor pago pela Maria: " + carrinhoComprasMaria.ValorFinal);

        }
    }
}
