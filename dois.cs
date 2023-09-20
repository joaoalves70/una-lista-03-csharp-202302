using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Valor da compra: ");
        decimal valorCompra = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Valor pago: ");
        decimal valorPago = Convert.ToDecimal(Console.ReadLine());

        if (valorPago < valorCompra)
        {
            Console.WriteLine("Quantia paga é insuficiente para realizar a compra.");
        }
        else
        {
            decimal troco = valorPago - valorCompra;
            Console.WriteLine($"Troco: R$ {troco:F2}");

            int notas50 = (int)(troco / 50);
            troco %= 50;

            int notas20 = (int)(troco / 20);
            troco %= 20;

            int notas10 = (int)(troco / 10);
            troco %= 10;

            int notas5 = (int)(troco / 5);
            troco %= 5;

            int notas2 = (int)(troco / 2);
            troco %= 2;

            int notas1 = (int)troco;

            Console.WriteLine($"Notas de R$ 50,00: {notas50}");
            Console.WriteLine($"Notas de R$ 20,00: {notas20}");
            Console.WriteLine($"Notas de R$ 10,00: {notas10}");
            Console.WriteLine($"Notas de R$ 5,00: {notas5}");
            Console.WriteLine($"Notas de R$ 2,00: {notas2}");
            Console.WriteLine($"Notas de R$ 1,00: {notas1}");
        }
    }
}