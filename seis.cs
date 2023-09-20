using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o primeiro número inteiro: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número inteiro: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int menorNumero, maiorNumero;

        if (numero1 < numero2)
        {
            menorNumero = numero1;
            maiorNumero = numero2;
        }
        else
        {
            menorNumero = numero2;
            maiorNumero = numero1;
        }

        Random random = new Random();
        int numeroSorteado = random.Next(menorNumero, maiorNumero + 1);

        Console.WriteLine($"Número sorteado: {numeroSorteado}");

        if (numeroSorteado % 2 == 0)
        {
            Console.WriteLine("O número sorteado é par.");
        }
        else
        {
            Console.WriteLine("O número sorteado é ímpar.");
        }
    }
}
