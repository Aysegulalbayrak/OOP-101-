//using static OOP.clsCarGallery;
namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sıra geldi tanımlanmış classdan bir örnek-instance-nesne yaratmaya
            //<Sınıf adı> <Nesne adı> = new <Sınıf adı>

            clsCarGallery carGallery = new clsCarGallery(); //Nesnem tanımlanmış sınıftan kendini örnekledi (instance aldı).

            //Nesnemizin elemanlaerına , özelliklerine ulaşalım.
            carGallery.Brand = "Mercedes";
            carGallery.Model = "C200";
            carGallery.Color = "Füme";
            Console.WriteLine("Markası: "+carGallery.Brand +", Modeli: "+carGallery.Model + " Rengi: "+ carGallery.Color);
            Console.WriteLine("Ücreti: "+carGallery.Price.ToString());
        }
        //Benim bir araba galerim var ve içinde arabalar var.
        //Dolayısıyla ilk öne içine verileri tutacak sınıfı tanımlayalım
        //Syntax: <erişim belirleyici> class <sınıfın adı>
        

    }
}