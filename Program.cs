using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();
        restaurant.menuGoster();
        

        while (true)
        {
            Console.WriteLine("1- Müşteri Al\n2- Menü Göster ve Sipariş Al\n3- Hesap Al\n4- Çıkış");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    restaurant.musteriOturt();
                    break;
                case "2":
                    restaurant.menuGosterSiparisAl();
                    break;
                case "3":
                    restaurant.hesapAl();
                    break;
                case "4":
                 
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }
}


