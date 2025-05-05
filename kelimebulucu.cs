using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] kelimeler = { "elma", "armut", "elma", "muz", "elma", "armut" };

        // Kelimele sözülüğü 
        Dictionary<string, int> kelimeSayilari = new Dictionary<string, int>();

        //kelimeleri say      foreach (string kelime in kelimeler)
        {
            if (kelimeSayilari.ContainsKey(kelime))
                kelimeSayilari[kelime]++;
            else
                kelimeSayilari[kelime] = 1;
        }

        // Sonuçları yazdır
        foreach (var item in kelimeSayilari)
        {
            Console.WriteLine($"{item.Key}: {item.Value} kez geçti");
        }
    }
}
