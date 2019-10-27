using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************  Loja de bebidas *************");
            Console.WriteLine("Bem vindo a Loja");

            List<string> listaClientes = new List<string>();

            for(int i=0; i<5; i++)
            {
                string nc =CadastrarCliente();
                listaClientes.Add(nc);
            }
            foreach (string item in listaClientes)
            { 
                Console.WriteLine($" Nome: {item} !");
            }
            
            Console.ReadKey();
        }
        static string CadastrarCliente()
        {
            Console.Write("Digite o seu nomeasdsa: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = $"{nome} {sobrenome}";

            return nomeCompleto;
        }
    }
}
