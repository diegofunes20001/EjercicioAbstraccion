using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public abstract class Operaciones
    { 
        /// <summary>
        /// Suma
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Text</returns>
        public abstract double Suma(double num1, double num2);
        /// <summary>
        /// Resta
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Text</returns>
        public abstract double Resta(double num1, double num2);
        /// <summary>
        /// Multiplicacion
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Text</returns>
        public abstract double Multiplicacion(double num1, double num2);
        /// <summary>
        /// Division
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>Text</returns>
        public abstract double Division(double num1, double num2);
        public abstract void Imprimir();

    }
}
