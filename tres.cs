using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o coeficiente 'a': ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente 'b': ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o coeficiente 'c': ");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (a == 0 && b == 0 && c != 0)
        {
            Console.WriteLine("Coeficientes informados incorretamente.");
        }
        else if (a == 0 && b != 0)
        {
            Console.WriteLine("Essa é uma equação de primeiro grau.");
            double raiz = -c / b;
            Console.WriteLine($"Valor da raiz real da equação: {raiz:F2}");
        }
        else if (delta < 0)
        {
            Console.WriteLine("Esta equação não possui raízes reais.");
        }
        else if (delta == 0)
        {
            Console.WriteLine("Esta equação possui duas raízes reais iguais.");
            double raiz = -b / (2 * a);
            Console.WriteLine($"Valor das raízes da equação: {raiz:F2}");
        }
        else
        {
            Console.WriteLine("Esta equação possui duas raízes reais diferentes.");
            double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Valor da primeira raiz: {raiz1:F2}");
            Console.WriteLine($"Valor da segunda raiz: {raiz2:F2}");
        }
    }
}
