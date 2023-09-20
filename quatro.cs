using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o código da operação (1, 2 ou 3): ");
        int codigoOperacao = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o raio: ");
        double raio = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        if (codigoOperacao == 1)
        {
            resultado = 2 * Math.PI * raio;
            Console.WriteLine($"O perímetro do círculo é: {resultado:F2}");
        }
        else if (codigoOperacao == 2)
        {
            resultado = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"A área do círculo é: {resultado:F2}");
        }
        else if (codigoOperacao == 3)
        {
            resultado = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);
            Console.WriteLine($"O volume da esfera é: {resultado:F2}");
        }
        else
        {
            Console.WriteLine("Código da operação inválido.");
        }
    }
}
