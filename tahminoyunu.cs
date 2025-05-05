using System;

class Program
{
    static void Main()
    {
        int dogruSayi = 23; 
        int dogruSayi= 99;
        int dogruSayi=1;
        int dogruSayi=100;
        int tahmin;
        int denemeSayisi = 0;

        Console.WriteLine("Tahmin Oyunu: 1-100 arasında sayıyı tahmin et!");

        while (true)
        {
            Console.Write("Tahmininizi girin: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            denemeSayisi++;

            if (tahmin == dogruSayi)
            {
                Console.WriteLine($"Tebrikler! {denemeSayisi} denemede doğru bildiniz.");
                break;
            }
            else if (tahmin < dogruSayi)
            {
                Console.WriteLine("Daha büyük bir sayı girin.");
            }
            else
            {
                Console.WriteLine("Daha küçük bir sayı girin.");
            }
        }
    }
}
