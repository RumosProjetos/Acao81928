using Gandalf.Inc.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Telas
{
    public class DadosCliente
    {
        public List<Cliente> DatabaseDeClientes { get; set; }
        private const string CaminhoDados = "dadoscliente.json";


        public DadosCliente()
        {
            Console.Clear();
            ObterDadosDosClientes();

            Console.WriteLine("==========================");
            Console.WriteLine("=      Gandalf.Inc       =");
            Console.WriteLine("==========================");
            Console.WriteLine("Modulo Clientes");


            string operacao = "";

            do
            {
                Console.WriteLine("Escolha Operacao");
                Console.WriteLine("'a' - Adicionar Novo Cliente");
                Console.WriteLine("'e' - Editar dados de Cliente");
                Console.WriteLine("'d' - Deletar dados Cliente");
                Console.WriteLine("'x' - Voltar para tela Login");

                operacao = Console.ReadLine().ToLower();

                if (operacao == "a")
                {
                    AdicionarCliente();
                }

                if (operacao == "d")
                {
                    // 9b81879a - 87b4 - 45ae - 982c - 4c0287f76942
                    Console.WriteLine("Informe Identificador do Cliente");
                    string temporario = Console.ReadLine();
                    Guid identificador = new Guid(temporario);
                    ApagarCliente(identificador);
                }
            } while (operacao != "x");
        }


        public void ApagarCliente(Guid identificador)
        {
            List<Cliente> local = new List<Cliente>();

            foreach (var cliente in DatabaseDeClientes)
            {
                if (cliente.Identificador != identificador)
                {
                    local.Add(cliente);
                }
            }

            DatabaseDeClientes = local;
            SalvarDadosCliente();
        }


        public void AdicionarCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Informe os dados do cliente");
            cliente = new Cliente();

            cliente.Identificador = Guid.NewGuid();

            Console.WriteLine("Nome do Cliente");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("NIF do Cliente");
            cliente.NumeroIdentidadeFiscal = Console.ReadLine();

            Console.WriteLine("Ano de Nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Mês de Nascimento");
            int mesNascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Dia do Nascimento");
            int diaNascimento = int.Parse(Console.ReadLine());

            cliente.DataNascimento = new DateTime(anoNascimento, mesNascimento, diaNascimento);

            cliente.Morada = new Morada();

            Console.WriteLine("Distrito");
            cliente.Morada.Distrito = Console.ReadLine();

            Console.WriteLine("Concelho");
            cliente.Morada.Concelho = Console.ReadLine();

            Console.WriteLine("CodigoPostal");
            cliente.Morada.CodigoPostal = Console.ReadLine();

            Console.WriteLine("CodigoPostalComplemento");
            cliente.Morada.CodigoPostalComplemento = Console.ReadLine();

            Console.WriteLine("Rua");
            cliente.Morada.Rua = Console.ReadLine();

            Console.WriteLine("NumeroPorta");
            cliente.Morada.NumeroPorta = Console.ReadLine();

            DatabaseDeClientes.Add(cliente);

            SalvarDadosCliente();
        }

        public void SalvarDadosCliente()
        {
            string ClienteEmJson = System.Text.Json.JsonSerializer.Serialize(DatabaseDeClientes);
            System.IO.File.WriteAllText(CaminhoDados, ClienteEmJson);
        }


        public void ObterDadosDosClientes()
        {
            if (System.IO.File.Exists(CaminhoDados))
            {
                DatabaseDeClientes = new List<Cliente>();

                try
                {
                    string conteudo = System.IO.File.ReadAllText(CaminhoDados);
                    DatabaseDeClientes = System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(conteudo);
                }
                catch (Exception)
                {
                    ///TODO: Decidir o que fazer com as excessões ...
                }
            }
        }
    }
}
