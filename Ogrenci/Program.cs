using System.Net.NetworkInformation;


namespace Ogrenci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsStudent ogrenci = new clsStudent();
            ogrenci.Ad = "Ayşegül";
            ogrenci.SoyAd = "Albayrak";
            ogrenci.Bolum = "Bilgisayar Programcılığı";
            ogrenci.Yas = 20;
            ogrenci.Cinsiyet = 'K';
            ogrenci.OgrenciNumarasi = "HR200000";
            Console.WriteLine("Adı Soyadı: "+ogrenci.Ad+" " + ogrenci.SoyAd.ToUpper());
            Console.WriteLine("Bolumü: " +ogrenci.Bolum);
            Console.WriteLine("Yaşı: " +ogrenci.Yas);
            Console.WriteLine("Cinsiyeti: " +ogrenci.Cinsiyet);
            Console.WriteLine("Öğrenci Numarası: " +ogrenci.OgrenciNumarasi);

            
        }

        public class Ogrenci
        {
            public string Ad { get; set; }
            public string SoyAd { get; set; }
            public string Bolum { get; set; }
            public int Yas { get; set; }
            public char Cinsiyet { get; set; }
            public string OgrenciNumarasi { get; set; }

        }
    }
}