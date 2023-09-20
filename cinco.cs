using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número real: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número real: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o símbolo da operação (+, -, *, /, ^): ");
        char operacao = Convert.ToChar(Console.ReadLine());

        double resultado = 0;

        switch (operacao)
        {
            case '+':
                resultado = numero1 + numero2;
                break;
            case '-':
                resultado = numero1 - numero2;
                break;
            case '*':
                resultado = numero1 * numero2;
                break;
            case '/':
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Divisão por zero não é permitida.");
                    return;
                }
                break;
            case '^':
                resultado = Math.Pow(numero1, numero2);
                break;
            default:
                Console.WriteLine("Símbolo da operação inválido.");
                return;
        }
        Console.WriteLine($"Resultado da operação: {resultado:F2}");
    }
}
