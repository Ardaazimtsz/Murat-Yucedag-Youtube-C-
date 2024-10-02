using System;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Toplam fiyatı tutmak için bir değişken oluşturuluyor.
            int totalPrice = 0;

            #region Yazdırma Komutları

            // "Hello World" ve "Merhaba Dünya" mesajlarını ekrana yazdırır.
            Console.WriteLine("Hello World");
            Console.WriteLine("Merhaba Dünya");

            // Console.Write metoduyla yazılan metin alt satıra geçmeden devam eder.
            Console.Write("Hello World");
            Console.WriteLine("Merhaba Dünya");

            // Menü başlıkları ve yemek kategorileri ekrana yazdırılır.
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Tatlılar");
            Console.WriteLine("5-Salatalar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            // String veri tipiyle bir isim değişkeni oluşturulup, isme bir değer atanıyor.
            string name;
            name = "Arda";
            // İsmi ekrana yazdırır.
            Console.WriteLine(name);

            // Müşteri bilgileri için string veri tipinde değişkenler tanımlanır.
            String cosutomerName;
            String cosutomerSurname;
            String cosutomerPhone;
            String cosutomerEmail, district, city;

            // Müşteri bilgilerine değer atanıyor.
            cosutomerName = "Arda Azim";
            cosutomerSurname = "Taşözü";
            cosutomerPhone = "05535702988";
            cosutomerEmail = "arda_azim.tas@hotmail.com";
            district = "Pendik";
            city = "İstanbul";

            // Müşteri bilgileri bir rezervasyon kartı formatında ekrana yazdırılıyor.
            Console.WriteLine("***** Rezervasyon Kartı ******");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + cosutomerName + " " + cosutomerSurname);
            Console.WriteLine("İletişim: " + cosutomerPhone);
            Console.WriteLine("Email Adresi: " + cosutomerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine();
            Console.WriteLine("***** Rezervasyon Kartı ******");

            #endregion

            #region Int Değişkenler

            // Integer veri tipiyle bir sayı değişkeni tanımlanır ve ekrana yazdırılır.
            int number;
            number = 24;
            Console.WriteLine(number);

            // Menüdeki ürün fiyatları için değişkenler tanımlanıyor.
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemondePrice = 30;

            // Restoran menüsündeki ürünler ve fiyatları ekrana yazdırılıyor.
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger : " + hamburgerPrice + " TL");
            Console.WriteLine("----- Pizza : " + pizzaPrice + " TL");
            Console.WriteLine("----- Kola : " + cokePrice + " TL");
            Console.WriteLine("----- Kızartma : " + friesPrice + " TL");
            Console.WriteLine("----- Su: " + waterPrice + " TL");
            Console.WriteLine("----- Limonata : " + lemondePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();

            // Satın alınan ürünlerin adetlerini tutmak için değişkenler tanımlanır.
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonCount;

            // Toplam ürün fiyatlarını hesaplamak için değişkenler tanımlanır.
            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonPrice = 0;

            // Ürün adetlerine değer atanıyor.
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 0;
            friesCount = 3;
            pizzaCount = 3;
            lemonCount = 1;

            // Toplam fiyatlar hesaplanıyor (adet * ürün fiyatı).
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesPrice * friesCount;
            totalLemonPrice = lemonCount * lemondePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            // Her ürün için toplam fiyat ekrana yazdırılıyor.
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonPrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");
            Console.WriteLine();

            // Tüm ürünlerin toplam tutarı hesaplanıp ekrana yazdırılıyor.
            int toplamTutar;
            toplamTutar = totalFriesPrice + totalCokePrice + totalLemonPrice + totalHamburgerPrice + totalWaterPrice + totalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + toplamTutar + " TL");
            Console.WriteLine("---------------------------------");

            #endregion

            // Konsolun kapanmasını engellemek için Read metodu çağrılıyor.
            Console.Read();
        }
    }
}
