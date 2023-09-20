using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double maior = Math.Max(numero1, Math.Max(numero2, numero3));
        double menor = Math.Min(numero1, Math.Min(numero2, numero3));
        double media = (numero1 + numero2 + numero3) / 3.0;

        Console.WriteLine($"O maior número é: {maior}");
        Console.WriteLine($"O menor número é: {menor}");
        Console.WriteLine($"A média aritmética dos três números é: {media:F2}");
    }
}