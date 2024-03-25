using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Restaurant
{
    private bool[] masalar = new bool[5];
    private List<MenuItem> MenuUrun = new List<MenuItem>();

    public void menuGoster()
    {
        MenuUrun.Add(new MenuItem("Ezogelin Çorbası", 75));
        MenuUrun.Add(new MenuItem("Mercimek Çorbası", 75));
        MenuUrun.Add(new MenuItem("Domates Çorbası", 75));
        MenuUrun.Add(new MenuItem("Akdeniz Salata", 120));
        MenuUrun.Add(new MenuItem("Çoban Salata", 100));
        MenuUrun.Add(new MenuItem("Rus Salatası", 130));
        MenuUrun.Add(new MenuItem("Adana Kebap", 300));
        MenuUrun.Add(new MenuItem("Tavuk Şiş", 250));
        MenuUrun.Add(new MenuItem("Steak", 400));
        MenuUrun.Add(new MenuItem("Spagetti", 150));
        MenuUrun.Add(new MenuItem("Penne Arabiata", 170));
        MenuUrun.Add(new MenuItem("Tavuklu Makarna", 190));
        MenuUrun.Add(new MenuItem("Kola", 50));
        MenuUrun.Add(new MenuItem("Ayran", 30));
        MenuUrun.Add(new MenuItem("Su", 20));
    }

    public void musteriOturt()
    {
        for (int i = 0; i < masalar.Length; i++)
        {
            if (!masalar[i])
            {
                masalar[i] = true;
                Console.WriteLine($"Müşteri {i + 1}. masaya oturtuldu.");
                return;
            }
        }
        Console.WriteLine("Boş masa yok.");
    }

    public void menuGosterSiparisAl()
    {
        Console.WriteLine("Menü:");
        foreach (var item in MenuUrun)
        {
            Console.WriteLine($"{item.Name} - {item.Fiyat} TL");
        }

        Console.WriteLine("Siparişinizi girin (Bitirmek için 'q' basın):");
        double total = 0;
        string secim;
        while ((secim = Console.ReadLine()) != "q")
        {
            foreach (var item in MenuUrun)
            {
                if (item.Name.Equals(secim, StringComparison.OrdinalIgnoreCase))
                {
                    total += item.Fiyat;
                    Console.WriteLine($"{item.Name}: {item.Fiyat} TL eklendi. Toplam: {total} TL");
                    break;
                }
            }
        }
        Console.WriteLine($"Toplam Sipariş Tutarı: {total} TL");
    }

    public void hesapAl()
    {
        Console.WriteLine("Hesabı kapatılacak masa numarasını girin:");
        int masaNumarasi = Convert.ToInt32(Console.ReadLine()) - 1;

        if (masaNumarasi >= 0 && masaNumarasi < masalar.Length && masalar[masaNumarasi])
        {
            masalar[masaNumarasi] = false;
            Console.WriteLine($"{masaNumarasi + 1}. masanın hesabı kapatıldı.");
        }
        else
        {
            Console.WriteLine("Geçersiz masa numarası veya masa zaten boş.");
        }
    }
}