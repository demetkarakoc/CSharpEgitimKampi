using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region For Döngüsü

            //int i;

            //for(i=1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 3; i<= 50; i +=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını isteiğniz adediiriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i =1; i<= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion


            #region For Döngüsü İle Karar Yapıları

            //for(int i=1; i<=100; i++)
            //{
            //    if(i % 5== 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}


            //int totalValue = 0;
            //for(int i= 1; i<= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);


            //int totalValue = 0;
            //for (int i= 1; i<20; i++)
            //{
            //    if(i % 2== 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("----------------");
            //Console.WriteLine(totalValue);



            //int count = 0;
            //for(int i = 1; i<= 50; i++)
            //{
            //    if(i% 7 ==0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);


            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}

            #endregion


            #region  While Döngüsü

            //int i = 1;
            //while(i<= 10)
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    i++;
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    if(1% 3 == 10)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;

            //while(i<= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion


            #region  Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundereds;
            //int sum;

            //ones = number % 10;
            //hundereds = number / 100;
            //tens = (number % 100) / 10;

            //Console.WriteLine(ones + "-" + tens + "-" + hundereds);

            //sum = ones + tens + hundereds;

            //Console.WriteLine(sum);

            #endregion

            #region  Alt alta 10 tane yıldız oluşturma

            //for (int i=1; i<=10; i++)
            //{
            //    Console.WriteLine();
            //}

            #endregion


            #region  Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++;)
            //{
            //    Console.Write("*");
            //}

            #endregion


            #region Alt alta  tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for(int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("*************");
            //}

            #endregion


            #region  Dik Üçgen

            //for(int i=1; i<=5; i++)
            //{
            //    for(int j=1; j<=2; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Üçgen

            //for(int i= 5; i>=1; i--)
            //{
            //    for(j =1; j<=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region  Dik ve Ters Üçgen Beraber

            //for(int i=1; i<=5; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write("i");
            //    }
            //    Console.WriteLine();   

            //}

            //for(int k=4; k>=1; k--)
            //{
            //    for (int m =1; m<k;m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region  Baklava Dilimi

            //int n=5;
            //for(int i = 1; i<=n; i++)
            //{
            //    for(int j = n-1; j>0; j--)
            //    {
            //        Console.WriteLine(" ");
            //    }

            //    for(int k=1; k<=2*i -1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();

            //}

            //for(int i=n-1; i>=1; i--)
            //{
            //    for(int j = n-1; j>0; j--)
            //    {
            //        Console.Write("  ");
            //    }

            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion


            #region Piramit

            //int n = 5;
            //for(int i=1; i<=n; i++)
            //{
            //    for(int j=n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            //int n = 5;
            //for(int i=n;i>=1; i--)
            //{
            //    for(int j=n-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}






            #endregion



            Console.Read();
        }
    }
}
