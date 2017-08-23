using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_dia_21_08_2017
{
    class Leao : Animal, ICorrer
    {
        private bool denticao;

        public Leao(int numeroCad, int idade, bool sex, bool denticao) : base(numeroCad, idade, sex)
        {
            this.Denticao = denticao;
        }

        public bool Denticao {
            get {
                return denticao;
            }
            set {
                denticao = value;
            }
        }

        public void Correr()
        {
            Console.WriteLine("Leão está correndo.");
        }

        public override void EmitirSom()
        {
            Console.WriteLine(" HOOOOOOAAAAAAAAARRRRRR.");
        }
    }
}
