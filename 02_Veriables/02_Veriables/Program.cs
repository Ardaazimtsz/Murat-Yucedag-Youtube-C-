using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.WriteLine("***** MEYVE VE SEBZE FİYAT LİSTESİ *****");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + " TL");
            Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + " TL");
            Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.500;
            tomatoGram = 3.745;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyatı: " + applePrice +
                " - Gramaj: " + appleGram + " -Toplam Tutar: " + appleTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyatı: " + orangePrice +
                " - Gramaj: " + orangeGram + " -Toplam Tutar: " + orangeTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice +
                " - Gramaj: " + strawberryGram + " -Toplam Tutar: " + strawberryTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyatı: " + potatoPrice +
                " - Gramaj: " + potatoGram + " -Toplam Tutar: " + potatoTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice +
                " - Gramaj: " + tomatoGram + " -Toplam Tutar: " + tomatoTotalPrice + " TL");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + potatoTotalPrice + tomatoTotalPrice + strawberryTotalPrice;

            Console.WriteLine();
            Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + " TL");
            Console.WriteLine("-----------------------------------------");
            #endregion

            #region Char değişkenler

            // Tek tırnakla yazılır
            char symbol;
            symbol = 'a';
            Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri : String Değişkenler

            Console.WriteLine("***** CSHARP HAVA YOLLARI YOLCU BİLGİSİ *****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
                passengerIdentityNumber;

            Console.Write("Yolcu Adı: ");
            passengerName = Console.ReadLine();

            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();

            Console.Write("Yolcu'nun Yaşadığı İlçe: ");
            passengerDistrict = Console.ReadLine();

            Console.Write("Yolcunun Yaşadığı Şehir: ");
            passengerCity = Console.ReadLine();

            Console.Write("Yolcunun Yaşı: ");
            passengerAge = Console.ReadLine();

            Console.Write("Yolcunun TC Kimlik Numarası: ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Yolcu'nun TC Kimlik No:" + passengerIdentityNumber + " " + "Yolcu'nun Adı Soyadı: " + passengerName + " " + passengerSurname + " " + passengerAge + " " +
                passengerDistrict + " " + passengerCity);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");

            #endregion

            #region Klvayeden Tam Sayı Girişleri ve Dönüşümler
            Console.WriteLine();
            Console.WriteLine("***** SAKARYA AVM FİYAT LİSTESİ *****");
            Console.WriteLine();

            int shoePrice, computerPrice, chairPrice, tvPrice;

            shoePrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoeCount, computerCount, chairCount, tvCount;

            Console.Write("Ayakkabı Adedi: ");
            shoeCount = int.Parse(Console.ReadLine());

            Console.Write("Bilgisayar Adedi: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Sandalye Adedi:");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("TV Adedi: ");
            tvCount = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int shoeTotalPrice, computerTotalPrice, chairTotalPrice, tvTotalPrice;

            shoeTotalPrice = shoePrice * shoeCount;
            computerTotalPrice = computerPrice * computerCount;
            chairTotalPrice = chairPrice * chairCount;
            tvTotalPrice = tvPrice * tvCount;

            Console.WriteLine("Alınan Ürün: Ayakkabı -  Birim Fiyatı: " + shoePrice +
                " Alınan Adet: " + shoeCount + " Toplam Fiyatı: " + shoeTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Bilgisayar -  Birim Fiyatı: " + computerPrice +
                " Alınan  Adet: " + computerCount + " Toplam Fiyatı: " + computerTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Sandalye -  Birim Fiyatı: " + chairPrice +
                " Alınan Adedi: " + chairCount + " Toplam Fiyatı: " + chairTotalPrice + " TL");

            Console.WriteLine("Alınan Ürün: Televizyon -  Birim Fiyatı: " + tvPrice +
                " Alınan Adedi: " + tvCount + " Toplam Fiyatı: " + tvTotalPrice + " TL");
            Console.WriteLine();

            int totalPrice;

            totalPrice = shoeTotalPrice + computerTotalPrice + chairTotalPrice + tvTotalPrice;

            Console.WriteLine("Toplam Alışveriş Tutarı: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondaklı Sayı İşlemleri

            double exam1, exam2, exam3, result;
            Console.Write("Lütfen 1. Sınav Notunu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Ortalama Sınav Notunuz: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion
            Console.Read();

        }

    }
}
