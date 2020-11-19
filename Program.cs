using System;

namespace Programa_user_e_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string senha;
            string usuario;
            do{
            Console.WriteLine("Digite seu nome de usuário: ");
            usuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            senha = Console.ReadLine();

            if(usuario == senha){
                Console.WriteLine("A senha não pode ser igual ao nome de usuário");
            }

            }while(usuario == senha);

            Console.WriteLine("Login concluído");
        }
        
    }
}
