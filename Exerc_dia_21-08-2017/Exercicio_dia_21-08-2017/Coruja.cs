using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_dia_21_08_2017
{
    class Coruja : Animal
    {
        private int habito;

        public Coruja(int numeroCad, int idade, bool sex, int habito) : base(numeroCad, idade, sex)
        {
            this.Habito = habito;
        }

        public int Habito {
            get {
                return habito;
            }
            set {
                habito = value;
            }
        }

        public override void EmitirSom()
        {
            Console.WriteLine(" Uuuuu Uuuuuu Uuuuuuu.");
        }
    }
}
