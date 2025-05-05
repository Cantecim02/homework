using System;

class Program
{
    static void Main()
    {
        string[] urunler = new string[5]; // 5 elemanlı dizi
        int sayac = 0;

        while (true)
        {
            Console.Write("Ürün adı girin (çık yazarsan işlem biter): ");
            string giris = Console.ReadLine();

            if (giris.ToLower() == "çık")
            {
                Console.WriteLine("Giriş işlemi sona erdi.");
                break;
            }

            if (sayac >= 5)
            {
                Console.WriteLine("Sepet doldu! Daha fazla ürün ekleyemezsiniz.");
                break;
            }

            urunler[sayac] = giris;
            sayac++;
        }

        Console.WriteLine("\n--- Sepetteki Ürünler ---");
        for (int i = 0; i < sayac; i++)
        {
            Console.WriteLine($"{i + 1}. {urunler[i]}");
        }
    }
}
