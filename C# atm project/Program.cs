using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__atm_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000;
            while (true)
            {
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("Bakiye görüntülemek için 1");
                Console.WriteLine("Para Çekmek için 2");
                Console.WriteLine("Para yatırmak için 3");
                Console.WriteLine("Çıkış yapmak için 4");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("bakiyeniz:"+bakiye);
                        Console.ReadLine();
                        break;
                    case "2":

                        Console.WriteLine("çekmek istediğiniz tutarı giriniz:");
                        int para;
                        para= Convert.ToInt32(Console.ReadLine());

                        if (para> bakiye)
                        {
                            Console.WriteLine("yetersiz bakiye:");
                            Console.ReadLine();
                        }
                        else
                        {
                            bakiye=bakiye-para;
                            Console.WriteLine("kalan bakiye:"+bakiye);
                            Console.ReadLine();
                        }
                        break;
                    case "3":

                        Console.WriteLine("yatıralacak tutarı giriniz:");
                        int yatir;
                        yatir= Convert.ToInt32(Console.ReadLine());
                        bakiye = bakiye+yatir;
                        Console.WriteLine("Yeni bakiyeniz:"+bakiye);
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Kart iade ediliyor...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("yanlış tuşlama geçerli bir tuşlama yapınız");
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}
