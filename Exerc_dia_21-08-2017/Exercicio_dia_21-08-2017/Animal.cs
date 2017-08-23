using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_dia_21_08_2017
{
    class Animal
    {
        private int numeroCad,idade;
        private bool sex;

        public override string ToString()
        {
            return base.ToString();
        }
        public Animal(int numeroCad, int idade, bool sex)      
        {
            this.numeroCad = numeroCad;
            this.idade = idade;
            this.sex = sex;
        }

        public int NumeroCad {
            get {
                return numeroCad;
            }
            set {
                numeroCad = value;
            }
        }
        public int Idade {
            get {
                return idade;
            }
            set {
                idade = value;
            }
        }
        public bool Sex {
            get {
                return sex;
            }
            set {
                sex = value;
            }
        }

        public virtual void EmitirSom()
        {

        }
    }
}
