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
        public List<Cliente> Clientes { get; set; }



        public DadosCliente()
        {
            Clientes = new List<Cliente>();

            Console.WriteLine("Modulo Clientes");
            Console.WriteLine("Escolha Operacao");
            Console.WriteLine("'Adicionar' - Adicionar Novo Cliente");
            Console.WriteLine("'Alterar' - Alterar dados de Cliente");
            Console.WriteLine("'Remover' - Apagar Cliente");
            Console.WriteLine("'Voltar' - Voltar para tela Login");

            string operacao = Console.ReadLine();
            if(operacao == "Adicionar")
            {
                AdicionarCliente();
            }

        }

        public void AdicionarCliente()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Informe os dados do cliente");
            cliente = new Cliente();

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

            Clientes.Add(cliente);
        }
    }
}
