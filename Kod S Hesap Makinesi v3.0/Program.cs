using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kod_S_Hesap_Makinesi_v3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s;
            string opt = "";

            Console.WriteLine("Birinci sayıyı giriniz=");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz=");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Operatörünüzü giriniz:");
            opt = (Console.ReadLine());

            switch (opt)
            {
                case "+":
                    {
                        s = a + b;
                        Console.WriteLine("Sonuç=" + s);

                        break;
                    }
                case "-":
                    {
                        if (a > b)
                            s = a - b;
                        else if (b > a)
                            s = b - a;
                        else
                            s = a - b;
                        Console.WriteLine("Sonuç=" + s);
                        break;
                    }
                case "*":
                    {
                        s = a * b;
                        Console.WriteLine("Sonuç=" + s);
                        break;
                    }

                case "/":
                    {
                        if (a / b == 0)
                        {
                            s = a / b;

                            Console.WriteLine("Sonuç=" + s);
                        }

                        else if (a / b != 0)
                            Console.WriteLine("İfadeler tam bölünmüyor!!!");

                        break;
                    }

                default:

                    Console.WriteLine("Yanlış bir operatör girdiniz tekrar deneyiniz");
                    break;
            }

            Console.ReadKey();
        }
    }
}
