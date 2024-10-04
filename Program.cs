using System;
using System.Linq.Expressions;


namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler
            //double number;

            //number = 4.58;

            //Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, strawberryPrice, potato, tomato;
            //double orangePrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potato + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomato + " TL");

            //double appleGram, strawGram, potatoGram, tomatoGram, orangeGram;

            //appleGram = 1.234;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double totalApplePrice = applePrice * appleGram;
            //double totalOrangePrice = orangePrice * orangeGram;
            //double totalStrawPrice = strawberryPrice * strawGram;
            //double totalPotatoPrice = potato * potatoGram;
            //double totalTomatoPrice = tomato * tomatoGram;


            //Console.WriteLine();
            //Console.WriteLine("***** TUTAR LİSTESİ *****");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyat: " + applePrice + "TL Toplam Tutar: " + totalApplePrice + "TL" + "Gramaj: " + appleGram+ "gr");
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat: " + orangePrice + "TL Toplam Tutar: " + totalOrangePrice + "TL" + "Gramaj: " + orangeGram + "gr");
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat: " + strawberryPrice + "TL Toplam Tutar: " + totalStrawPrice + "TL" + "Gramaj: " + strawGram + "gr");
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat: " + potato + "TL Toplam Tutar: " + totalPotatoPrice + "TL" + "Gramaj: " + potatoGram + "gr");
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat: " + tomato + "TL Toplam Tutar: " + totalTomatoPrice + "TL" + "Gramaj: " + tomatoGram + "gr");

            //double shoppingTotalPrice = totalApplePrice + totalPotatoPrice + totalTomatoPrice + totalOrangePrice + totalStrawPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + shoppingTotalPrice + "TL");
            #endregion

            #region Char Değişkenler
            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);



            #endregion

            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDisctrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDisctrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Kimlik Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //Console.Write("Yolcu TC Kimlik No: "+passengerIdentityNumber +" - Yolcu Ad Soyad: " +passengerName+" "+passengerSurname+ " "+ passengerDisctrict + " / "+ passengerCity+ " "+passengerAge);





            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler


            //ABC12D

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount* chairPrice + tvCount * tvPrice;
            //Console.Write("Toplam Tutar " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + 
            //    result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion
            Console.Read();
        }
    }
}
