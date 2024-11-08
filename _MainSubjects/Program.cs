using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("*******Yemek Kategorileri *******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*****Yemek Kategorileri******");
            #endregion

            #region StringDeğişkenler

            //string name;
            //name = "Demet";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Fatma";
            //customerSurname = "Karakoç";
            //customerPhone = "+90 500 200 1121";
            //customerEmail = "deneme@gmail.com";
            //district = "Kağıthane";
            //city = "İstanbul";

            //Console.WriteLine("*****Rezervasyon Kartı*********");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:"+ customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------------");


            //Console.WriteLine();


            //customerName = "Ayşe";
            //customerSurname = "Kara";
            //customerPhone = "+90 550 600 1623";
            //customerEmail = "test@gmail.com";
            //district = "Bornova";
            //city = "İzmir";
            //Console.WriteLine(customerName);

            //Console.WriteLine("*****Rezervasyon Kartı*********");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres:" + district + "/" + city);
            //Console.WriteLine("-------------------------------------------------------");

            #endregion

            #region Int Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("******Restoran Menü Fiyatları******");
            Console.WriteLine();
            Console.WriteLine("------Hamburger:" + hamburgerPrice + "TL");
            Console.WriteLine("------Coke:" + cokePrice + "TL");
            Console.WriteLine("------Water:" + waterPrice + "TL");
            Console.WriteLine("------Fries:" + friesPrice + "TL");
            Console.WriteLine("------Pizza:" + pizzaPrice + "TL");
            Console.WriteLine("------Lemonade:" + lemonadePrice + "TL");
            Console.WriteLine("******Restoran Menü Fiyatları*********");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;



            hamburgerCount = 3;
            cokeCount= 3;
            waterCount= 3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount=0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadePrice * lemonadePrice;
    
            

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalHamburgerPrice + "TL");
            Console.WriteLine("Coke Tutarı:" + totalCokePrice + "TL");
            Console.WriteLine("Water Tutarı:" + totalWaterPrice + "TL");
            Console.WriteLine("Fries Tutarı:" + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + "TL");
            Console.WriteLine("Lemonade Tutarı:" + totalLemonadePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalFriesPrice + totalHamburgerPrice + totalPizzaPrice;
            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + "TL");


            #endregion


            Console.Read();
        }
    }
}
