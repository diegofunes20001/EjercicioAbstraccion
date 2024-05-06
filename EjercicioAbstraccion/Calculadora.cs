using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class Calculadora : Operaciones
    {
        private double _num1;
        private double _num2;

        public Calculadora(double num1, double num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public override double Suma(double num1, double num2)
        {
            return num1 + num2;
        }

        public override double Resta(double num1, double num2)
        {
            return num1 - num2;
        }

        public override double Multiplicacion(double num1, double num2)
        {
            return num1 * num2;
        }

        public override double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                return num1 / num2;
            }
            return num1 / num2;
        }

        /// <summary>
        /// Imprimir
        /// </summary>
        public override void Imprimir()
        {
            Console.WriteLine("Los números ingresados son: " + _num1 + " y " + _num2);
            Console.WriteLine("La suma es: " + Suma(_num1, _num2));
            Console.WriteLine("La resta es: " + Resta(_num1, _num2));
            Console.WriteLine("La multiplicación es: " + Multiplicacion(_num1, _num2));
            Console.WriteLine("La división es: " + Division(_num1, _num2));
        }
    }
}
