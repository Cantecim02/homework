using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir gün adı girin (örn: Pazartesi) veya 'hafta' yazarak tüm programı görün: ");
        string giris = Console.ReadLine().ToLower();

        switch (giris)
        {
            case "pazartesi":
                Yazdir("Pazartesi", new string[] { "Veritabanı Yönetim Sistemleri", "Yazılım Mühendisliği", "Dijital Elektronik" });
                break;
            case "salı":
                Yazdir("Salı", new string[] { "Olasılık ve İstatistik", "Algoritmalar ve Veri Yapıları", "Bilgisayar Ağları" });
                break;
            case "çarşamba":
                Yazdir("Çarşamba", new string[] { "Yapay Zeka", "İşletim Sistemleri", "Programlamaya Giriş" });
                break;
            case "perşembe":
                Yazdir("Perşembe", new string[] { "Web Programlama", "Mobil Uygulama Geliştirme", "Sosyal Bilimler" });
                break;
            case "cuma":
                Yazdir("Cuma", new string[] { "Makine Öğrenmesi", "Veri Madenciliği", "Elektrik Devreleri" });
                break;
            case "cumartesi":
            case "pazar":
                Yazdir(giris.Substring(0, 1).ToUpper() + giris.Substring(1), new string[] { "Tatilsiniz " });
                break;
            case "hafta":
                TumHafta();
                break;
            default:
                Console.WriteLine("Geçerli bir gün adı girin!");
                break;
        }
    }

    static void Yazdir(string gun, string[] dersler)
    {
        Console.WriteLine($"\n {gun} Günü Ders Programı:");
        foreach (string ders in dersler)
        {
            Console.WriteLine("- " + ders);
        }
    }

    static void TumHafta() //:(
    {
        Yazdir("Pazartesi", new string[] { "Veritabanı Sistemleri", "Yazılım Mühendisliği", "Dijital Elektronik" });
        Yazdir("Salı", new string[] { "Olasılık ve İstatistik", "Algoritmalar ve Veri Yapıları", "Bilgisayar Ağları" });
        Yazdir("Çarşamba", new string[] { "Yapay Zeka", "İşletim Sistemleri", "Programlamaya Giriş" });
        Yazdir("Perşembe", new string[] { "Web Programlama", "Mobil Uygulama Geliştirme", "Sosyal Bilimler" });
        Yazdir("Cuma", new string[] { "Makine Öğrenmesi", "Veri Madenciliği", "Elektrik Devreleri" });
        Yazdir("Cumartesi", new string[] { "Tatilsiniz " });
        Yazdir("Pazar", new string[] { "Tatilsiniz " });
    }
}
