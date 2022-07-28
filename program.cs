using System.Net;

namespace odev;
class Program

{
    static void Main(string[] args)
    {

        int[] ana_koleksiyon = new int[20];
        int[] asal_koleksiyon;
        int[] nonasal_koleksiyon;
        int asal_sayac = 0, non_asal_sayac = 0;
        int n = 0;

        System.Console.WriteLine(ana_koleksiyon.Count() + " Adet sayı giriniz");

        for (int i = 0; i < ana_koleksiyon.Count(); i++)
        {
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {

                ana_koleksiyon[i] = n;

                if (IsPrime(n))
                {
                    asal_sayac++;
                }
                else
                {
                    non_asal_sayac++;
                }
            }
            else
            {
                Console.WriteLine("Geçerli Sayısal Değer Giriniz");
                i--;
            }


        }


        asal_koleksiyon = new int[asal_sayac];
        nonasal_koleksiyon = new int[non_asal_sayac];

        int asal = 0, non = 0;

        foreach (var item in ana_koleksiyon)
        {
            if (IsPrime(item))
            {
                asal_koleksiyon[asal] = item;
                asal++;
            }
            else
            {
                nonasal_koleksiyon[non] = item;
                non++;
            }
        }

        System.Console.WriteLine("Asal Sayılar");
        Array.Reverse(asal_koleksiyon);
        foreach (var item in asal_koleksiyon)
        {
            System.Console.WriteLine(item);
        }

        
        System.Console.WriteLine("Asal Olmayan Sayılar");
        Array.Reverse(nonasal_koleksiyon);
        foreach (var item in nonasal_koleksiyon)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("Asal Sayıların Toplamı: " + asal_sayac);
        System.Console.WriteLine("Asal Olmayan Sayıların Toplamı: " + non_asal_sayac);

        if (asal_sayac < 1 || non_asal_sayac <1)
        {
            System.Console.WriteLine("Asal ya da asal olmayan sayı yok ortalama verilemez");
            return;
        }

        System.Console.WriteLine("Asal Sayıların Ortalaması: " + (asal_koleksiyon.Sum() / asal_koleksiyon.Count()));
        System.Console.WriteLine("Asal Olmayan Sayıların Ortalaması: " + (nonasal_koleksiyon.Sum() / nonasal_koleksiyon.Count()));



    }

    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}


