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

        public Login()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("=      Gandalf.Inc       =");
            Console.WriteLine("==========================");

            string mensagem = "Bom dia";

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

            Console.WriteLine("Informe usuário");
            Usuario = Console.ReadLine();

            Console.WriteLine("Informe senha");
            Senha = Console.ReadLine();
        }
    }
}
