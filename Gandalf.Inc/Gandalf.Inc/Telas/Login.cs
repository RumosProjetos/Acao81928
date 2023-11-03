using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gandalf.Inc.Telas
{
    public class Login
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        private Dictionary<string, string> UsuariosDoSistema { get; set; }
        private int ContadorDeTentativasDeAcessos { get; set; }

        private void IniciarListaUsuarios()
        {
            UsuariosDoSistema = new Dictionary<string, string>();
            UsuariosDoSistema.Add("Ana", "123456");
            UsuariosDoSistema.Add("Maria", "654321");
            UsuariosDoSistema.Add("Jose", "111111");
        }

        private bool ValidarUsuarioSenha(string usuario, string senha)
        {
            bool resultado = false;

            foreach (var item in UsuariosDoSistema)
            {
                if (item.Key == usuario && item.Value == senha)
                {
                    resultado = true;
                    break;
                }
            }

            return resultado;
        }

        public Login()
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine("=      Gandalf.Inc       =");
            Console.WriteLine("==========================");

            IniciarListaUsuarios();


            string mensagem = "Bom dia";
            ContadorDeTentativasDeAcessos = 0;

            if (DateTime.Now.Hour >= 7 && DateTime.Now.Hour <= 12)
            {
                mensagem = "Bom dia";
            }
            else
            {
                if (DateTime.Now.Hour > 12 && DateTime.Now.Hour <= 18)
                {
                    mensagem = "Boa tarde";
                }
                else
                {
                    mensagem = "Boa noite";
                }
            }

            Console.WriteLine(mensagem + " bem vindo");
            InformarUsuarioESenha();
        }

        private void InformarUsuarioESenha()
        {
            if (ContadorDeTentativasDeAcessos >= 3)
            {
                Console.WriteLine("Sistema Bloqueado por tentativas de acesso incorretas");
                return;
            }

            Console.WriteLine("Informe usuário");
            Usuario = Console.ReadLine();

            Console.WriteLine("Informe senha");
            Senha = Console.ReadLine();


            if (ValidarUsuarioSenha(Usuario, Senha))
            {
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("Digite 'c' para o Módulo de Clientes");
                Console.WriteLine("Digite 'p' para o Módulo de Produtos");

                string modulo = Console.ReadLine();
                //TODO: Adicionar loop de operacoes
                if (modulo.ToLower() == "c".ToLower())
                {
                    DadosCliente dadosCliente = new DadosCliente();
                }

            }
            else
            {
                ContadorDeTentativasDeAcessos++;
                InformarUsuarioESenha();
            }
        }

    }
}
