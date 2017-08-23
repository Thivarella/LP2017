using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_dia_21_08_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] jaula = new Animal[150];
            Random a = new Random();

            for(int i =0; i < 50; i++) {
                if (i%2 == 0) {
                    jaula[i] = new Leao(i + 1, i,true,true);
                    jaula[i + 50] = new Lobo(i + 51, i,true,true);
                    jaula[i + 100] = new Coruja(i + 101, i, true, a.Next(3));
                }
                else {
                    jaula[i] = new Leao(i + 1, i,false,false);
                    jaula[i + 50] = new Lobo(i + 51, i,false,false);
                    jaula[i + 100] = new Coruja(i + 101, i,false,a.Next(3));
                }
            }

            foreach(Animal e in jaula) {
                Console.WriteLine(e.GetType().Name);
                Console.WriteLine("Numero Cad: " + e.NumeroCad);
                Console.WriteLine("Idade: " + e.Idade);
                if (e.Sex) { 
                    Console.WriteLine("Sexo: Macho");
                }
                else {
                    Console.WriteLine("Sexo: Femea");
                }
                if(e is Leao) {
                    if (((Leao)e).Denticao) {
                        Console.WriteLine("Dentição: possui dentes.");
                    }
                    else {
                        Console.WriteLine("Dentição: não possui dentes.");
                    }
                }
                if(e is Lobo) {
                    if (((Lobo)e).CorPelo) {
                        Console.WriteLine("Pelagem: Branca");
                    }
                    else {
                        Console.WriteLine("Pelagem: Cinzento");
                    }
                }
                if(e is Coruja) {
                    switch (((Coruja)e).Habito) {
                        case 0:
                            Console.WriteLine("Habito: Diurno");
                            break;
                        case 1:
                            Console.WriteLine("Habito: Noturno");
                            break;
                        case 2:
                            Console.WriteLine("Habito: Diurno e Noturno");
                            break;
                    }
                }
                if(e is ICorrer) {
                    ((ICorrer)e).Correr();
                }
                e.EmitirSom();
                Console.WriteLine();
            }
            Console.Read();
        }

        
    }
}
