using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação (soma, subtração, multiplicação, divisão):");
            string operacao = Console.ReadLine().ToLower();

            int resultado = 0;

            switch (operacao)
            {
                case "soma":
                    resultado = valor1 + valor2;
                    break;
                case "subtração":
                    resultado = valor1 - valor2;
                    break;
                case "multiplicação":
                    resultado = valor1 * valor2;
                    break;
                case "divisão":
                    if (valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    return;
            }

            Console.WriteLine($"O resultado da {operacao} de {valor1} e {valor2} é: {resultado}");
            {
                Console.ReadKey();
            }
        }
    }
}
    
