using System;

class Program
{
    static void Main()
    {
        Console.Write("1 ile 12 arasında bir ay numarası girin: ");
        int ay = Convert.ToInt32(Console.ReadLine());

        switch (ay)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış mevsimi");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar mevsimi");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz mevsimi");
                break;

            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar mevsimi");
                break;

            default:
                Console.WriteLine("Geçersiz ay numarası. Lütfen 1 ile 12 arasında bir değer girin.");
                break;
        }
    }
}
