using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_dia_21_08_2017
{
    class Lobo : Animal, ICorrer
    {
        private bool corPelo;

        public Lobo(int numeroCad, int idade, bool sex, bool corPelo) : base(numeroCad, idade, sex)
        {
            this.CorPelo = corPelo;
        }
        public bool CorPelo {
            get {
                return corPelo;
            }
            set {
                corPelo = value;
            }
        }
        public void Correr()
        {
            Console.WriteLine("Lobo está correndo.");
        }

        public override void EmitirSom()
        {
            Console.WriteLine(" AAAAAAAAAAAAAAUUUUUUUUUUUUUUUUUUUUUU.");
        }
    }
}
