using EjercicioAbstraccion;

object? num1 = 0;
object? num2 = 0;

Calculadora calculadora = new Calculadora(4,2);

Console.WriteLine("Calculadora de Numero es:");
num1=Console.ReadLine();
Console.WriteLine("Calculadora de Numero2 es:");
num2 = Console.ReadLine();
calculadora.Imprimir();
