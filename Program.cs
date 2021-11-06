using System;

namespace Exercicio_Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
           //realizar uma divisão e caso o usuario digite o denominador = 0 exibir a seguinte mensagem "não é possivel dividi um numero por zero.

            double numerador, denominador, resultado;
            
            Console.Write("\nDigite o númerador:... ");
            numerador = Convert.ToDouble(Console.ReadLine());
 
            Console.Write("Digite um númerador:.. ");
            denominador = Convert.ToDouble(Console.ReadLine());

            resultado = numerador/denominador;

            if(denominador==0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                Console.WriteLine($"{numerador} dividido por {denominador} é {resultado:N1}.");
            }
            Console.WriteLine("");





        }
    }
}
