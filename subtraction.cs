using System;

class Subtraction
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap so thu nhat:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhap so thu hai:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int tru = TinhHieu(num1, num2);
        Console.WriteLine("Hieu cua hai so la: " + tru);
    }

    static int TinhHieu(int a, int b)
    {
        return a - b;
    }
}
