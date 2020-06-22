using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Calculadora
{
    class Calcular
    {

        private float valor1;
        private float valor2;
        private float  final;

        public Calcular(float valor1, float valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }


        public float resultado(string operador)
        {

            switch (operador)
            {
                case "+":
                    this.final = this.adicao();
                    break;
                case "-":
                    this.final = this.subtracao();
                    break;
                case "*":
                    this.final = this.multiplicacao();
                    break;
                case "/":
                    this.final = this.divisao();
                    break;

            }

            return this.final;
        }
        private float adicao()
        {
            return this.valor1 + this.valor2;
        }
        private float subtracao()
        {

            return this.valor1 - this.valor2;
        }
        private float multiplicacao()
        {

            return this.valor1 * this.valor2;
        }
        private float divisao()
        {
            return this.valor1 / this.valor2;
        }
    }
}
