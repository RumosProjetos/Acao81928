using Gandalf.Inc.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Telas
{
    public class DadosProdutos
    {
        public List<Produto> DatabaseDeProdutos { get; set; }
        private const string CaminhoDados = "dadosproduto.json";

        public DadosProdutos() {
            CriarListaExemplos();

            Console.Clear();
            ObterDadosDosProdutos();

            Console.WriteLine("==========================");
            Console.WriteLine("=      Gandalf.Inc       =");
            Console.WriteLine("==========================");
            Console.WriteLine("Modulo Produtos");


            string operacao = "";

            do
            {
                Console.WriteLine("Escolha Operacao");
                Console.WriteLine("'a' - Adicionar Novo Produto");
                Console.WriteLine("'e' - Editar dados de Produto");
                Console.WriteLine("'d' - Deletar dados Produto");
                Console.WriteLine("'x' - Voltar para tela Login");

                operacao = Console.ReadLine().ToLower();

                if (operacao == "a")
                {
                    AdicionarProduto();
                }

                if (operacao == "e")
                {
                    Console.WriteLine("Informe Identificador do Produto");
                    string temporario = Console.ReadLine();

                    Console.WriteLine("Informe Novo Nome do Produto");
                    string nomeNovo = Console.ReadLine();

                    Guid identificador = new Guid(temporario);
                    EditarNomeProduto(identificador, nomeNovo);
                }

                if (operacao == "d")
                {
                    Console.WriteLine("Informe Identificador do Produto");
                    string temporario = Console.ReadLine();
                    Guid identificador = new Guid(temporario);
                    ApagarProduto(identificador);
                }
            } while (operacao != "x");


            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("Digite 'c' para o Módulo de Produtos");
            Console.WriteLine("Digite 'p' para o Módulo de Produtos");

            string modulo = Console.ReadLine();

            if (modulo.ToLower() == "c".ToLower())
            {
                DadosProdutos dadosProduto = new DadosProdutos();
            }

            if (modulo.ToLower() == "p".ToLower())
            {
                DadosProdutos dadosProduto = new DadosProdutos();
            }
        }

        private void ApagarProduto(Guid identificador)
        {
            List<Produto> local = new List<Produto>();

            foreach (var Produto in DatabaseDeProdutos)
            {
                if (Produto.Identificador != identificador)
                {
                    local.Add(Produto);
                }
            }

            DatabaseDeProdutos = local;
            SalvarDadosProdutos();
        }

        private void EditarNomeProduto(Guid identificador, string nomeNovo)
        {
            List<Produto> local = new List<Produto>();

            foreach (var Produto in DatabaseDeProdutos)
            {
                if (Produto.Identificador == identificador)
                {
                    Produto.Nome = nomeNovo;
                }

                local.Add(Produto);
            }

            DatabaseDeProdutos = local;
            SalvarDadosProdutos();
        }

        private void AdicionarProduto()
        {
            Produto Produto = new Produto();

            Console.WriteLine("Informe os dados do Produto");
            Produto = new Produto();

            Produto.Identificador = Guid.NewGuid();

            Console.WriteLine("Nome do Produto");
            Produto.Nome = Console.ReadLine();

            Console.WriteLine("Categoria do Produto");
            Produto.Categoria = Console.ReadLine();

            Console.WriteLine("Marca do Produto");
            Produto.Marca = Console.ReadLine();

            Console.WriteLine("Preço Unitário");
            Produto.PrecoUnitario = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Quantidade em Estoque");
            Produto.QuantidadeEmEstoque = Convert.ToInt32(Console.ReadLine());


            DatabaseDeProdutos.Add(Produto);

            SalvarDadosProdutos();
        }

        private void CriarListaExemplos()
        {
            DatabaseDeProdutos = new List<Produto>
            {
                new Produto
                {
                    Identificador = Guid.NewGuid(),
                    Categoria = "Computador",
                    Marca = "IBM",
                    Nome = "IBM PC",
                    PrecoUnitario = 1000,
                    QuantidadeEmEstoque = 10
                },
                new Produto
                {
                    Identificador = Guid.NewGuid(),
                    Categoria = "Impressora",
                    Marca = "HP",
                    Nome = "HP Deskjet",
                    PrecoUnitario = 100,
                    QuantidadeEmEstoque = 10
                },
                new Produto
                {
                    Identificador = Guid.NewGuid(),
                    Categoria = "SmartPhone",
                    Marca = "Apple",
                    Nome = "iPhone",
                    PrecoUnitario = 1500,
                    QuantidadeEmEstoque = 10
                },
            };

            if(System.IO.File.Exists(CaminhoDados) == false)
            {
                SalvarDadosProdutos();
            }            
        }


        public void BuscarProdutoPorNome(string nome)
        {
            Produto produtoLocal = new Produto();

            foreach (var produto in DatabaseDeProdutos)
            {
                if(produto.Nome == nome)
                {
                    produtoLocal = produto;
                }
            }

            MostrarProduto(produtoLocal);
        }

        public void BuscarProdutoPorMarca(string marca)
        {
            Produto produtoLocal = new Produto();

            foreach (var produto in DatabaseDeProdutos)
            {
                if (produto.Marca == marca)
                {
                    produtoLocal = produto;
                }
            }

            MostrarProduto(produtoLocal);
        }

        public void BuscarProdutoPorCategoria(string categoria)
        {
            Produto produtoLocal = new Produto();

            foreach (var produto in DatabaseDeProdutos)
            {
                if (produto.Categoria == categoria)
                {
                    produtoLocal = produto;
                }
            }

            MostrarProduto(produtoLocal);
        }



        public void MostrarProduto(Produto produto)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("O produto selecionado foi:");
            Console.WriteLine("Nome: " + produto.Nome);
            Console.WriteLine("Marca: " + produto.Marca);
            Console.WriteLine("Categoria: " + produto.Categoria);
            Console.WriteLine("Quantidade em Estoque: " + produto.QuantidadeEmEstoque);
            Console.WriteLine("Preço Unitário: " + produto.PrecoUnitario);
            Console.WriteLine("--------------------------");
        }



        public void SalvarDadosProdutos()
        {
            string dadosEmJson = System.Text.Json.JsonSerializer.Serialize(DatabaseDeProdutos);
            System.IO.File.WriteAllText(CaminhoDados, dadosEmJson);
        }


        public void ObterDadosDosProdutos()
        {
            if (System.IO.File.Exists(CaminhoDados))
            {
                DatabaseDeProdutos = new List<Produto>();

                try
                {
                    string conteudo = System.IO.File.ReadAllText(CaminhoDados);
                    DatabaseDeProdutos = System.Text.Json.JsonSerializer.Deserialize<List<Produto>>(conteudo);
                }
                catch (Exception)
                {
                    ///TODO: Decidir o que fazer com as excessões ...
                }
            }
        }
    }
}
