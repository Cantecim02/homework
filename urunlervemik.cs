using System;

class Program
{
    static void Main()
    {
       
        string[] ürünler = { "Ekmek", "Süt", "Yumurta", "Peynir", "Makarna" };
        int[] miktarlar = { 10, 20, 30, 5, 15 }; 

        while (true)
        {
            
            Console.WriteLine("Mevcut ürünler ve miktarlar:");
            for (int i = 0; i < ürünler.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {ürünler[i]} - Miktar: {miktarlar[i]}");
            }

            // Kullanıcıdan bir ürün seçmesini istiyoruz
            Console.Write("\nBir ürün numarası seçin (1-5) veya çıkmak için 'q' tuşlayın: ");
            string secim = Console.ReadLine().ToLower();

            
            if (secim == "q")
            {
                break;
            }

           
            if (int.TryParse(secim, out int ürünNo) && ürünNo >= 1 && ürünNo <= ürünler.Length)
            {
                // Seçilen ürünün indeksine göre, kullanıcıya miktar değiştirme işlemi yapılır
                Console.Write($"Seçilen ürün: {ürünler[ürünNo - 1]}. Yeni miktarı girin: ");
                int yeniMiktar = Convert.ToInt32(Console.ReadLine());

                // Miktar günc
                miktarlar[ürünNo - 1] = yeniMiktar;

                Console.WriteLine($"{ürünler[ürünNo - 1]} ürününün miktarı başarıyla güncellendi. Yeni miktar: {yeniMiktar}\n");
            }
            else
            {
                Console.WriteLine("Geçersiz bir seçenek girdiniz. Lütfen geçerli bir ürün numarası girin.\n");
            }
        }

        Console.WriteLine("\nProgram sonlandırıldı.");
    }
}
