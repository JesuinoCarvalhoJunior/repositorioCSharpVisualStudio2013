using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Calculadora
    {
        private Double _valor1;
        public Double Valor1
        {
            get { return _valor1; }
            set { _valor1 = value; }
        }

        private Double _valor2;
        public Double Valor2
        {
            get { return _valor2; }
            set { _valor2 = value; }
        }

        public enum Operacao { Soma, subtracao, Multiplicacao, Divisao }

        public Calculadora()
        {

        }

        public Calculadora(Double V1, Double V2)
        {
            this._valor1 = V1;
            this._valor2 = V2;
        }

        public Double Somar()
        {
            return this._valor1 + this._valor2;
        }

        public Double Subtrair()
        {
            return this._valor1 - this._valor2;
        }

        public Double Multiplicar()
        {
            return this._valor1 * this.Valor2;
        }

        public Double Dividir()
        {
            return this.Valor1 / this.Valor2;
        }

        public Double Calcular (Operacao oper)
        { 
            switch (oper)
            {
                case Operacao.Soma:
                    return Somar();
                case Operacao.subtracao:
                    return Subtrair();
                case Operacao.Multiplicacao:
                    return Multiplicar();
                case Operacao.Divisao:
                    return Dividir();
                default:
                    return 0;
            }
        }

    }

}
