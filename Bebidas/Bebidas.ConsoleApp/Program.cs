using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bebidas.ConsoleApp.Classes;

namespace Bebidas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************  Loja de bebidas *************");
            Console.WriteLine("Bem vindo a Loja");
            


            Dados dados = new Dados();
            for(int i=0; i<5; i++)
            {
                Pessoa p = CadastrarCliente();
                dados.Salvar(p);
            }

            List<Pessoa> listaClientes = dados.LerTodos();

            foreach (Pessoa item in listaClientes)
            { 
                Console.WriteLine($" Nome completo: {item.Nome} {item.Sobrenome}");
            }
            
            Console.ReadKey();
        }
        static Pessoa CadastrarCliente()
        {
            Pessoa pessoa1 = new Pessoa();

            Console.Write("Digite o seu nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Digite o seu sobrenome: ");
            pessoa1.Sobrenome = Console.ReadLine();

            //string nomeCompleto = $"{pessoa1.Nome} {pessoa1.Sobrenome}";

            return pessoa1;
        }
    }
}
