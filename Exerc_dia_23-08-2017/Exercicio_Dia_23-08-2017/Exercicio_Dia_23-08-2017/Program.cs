using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Dia_23_08_2017
{
    class Program
    {
        static Dictionary<long, Pessoa> clientes = new Dictionary<long, Pessoa>();
        static void Main(string[] args)
        {
            int opcao = 0;
            while (true)
            {
                Console.WriteLine("1 - Add Cliente\n2 - Add Cachorro\n3 - Listar Todos\n0 - Sair\n");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao) {
                    case 1:
                        AddPessoa();
                        break;
                    case 2:
                        AddCachorro();
                        break;
                    case 3:
                        ListarTodos();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } 
            Console.Read();

        }
        public static void AddPessoa()
        {
            Pessoa p = new Pessoa();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("CPF: ");
            p.Cpf = long.Parse(Console.ReadLine());
            clientes.Add(p.Cpf,p);
        }

        public static void AddCachorro()
        {
            Console.Write("CPF do Dono: ");
            long cpf = long.Parse(Console.ReadLine());
            Pessoa p = clientes[cpf];

            Cachorro dogao = new Cachorro();
            Console.Write("Nome do cachorro: ");
            dogao.Nome = Console.ReadLine();
            Console.Write("Raça: ");
            dogao.Raca = Console.ReadLine();
            Console.Write("Está vacinado?");
            dogao.Vacinado = bool.Parse(Console.ReadLine());

            p.AddCachorros(dogao);
        }

        public static void ListarTodos()
        {
            foreach (KeyValuePair<long, Pessoa> p in clientes)
                Console.WriteLine(p.Value);
        }
    }
}
