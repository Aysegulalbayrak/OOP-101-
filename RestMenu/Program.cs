namespace RestMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kategori
            clsCategori clsCategori = new clsCategori();
            clsCategori.CatId = 1;
            clsCategori.CatName = "Çorbalar";

            Console.WriteLine("Kategori Listesi" + "\n\n");
            Console.WriteLine("=====================================" + "\n\n");
            Console.WriteLine(clsCategori.CatId + "\t"+clsCategori.CatName);

            //Food
            clsMenu clsMenu = new clsMenu();
            clsMenu.MenuId = 1;
            clsMenu.MenuName = "P100KY Restaurant";
            clsMenu.FoodName = "Mercimek Çorba";
            clsMenu.FoodPrice = 40;
            clsMenu.CatId = 1;

            Console.WriteLine(clsMenu.MenuName + " Yemek Listesi");
            Console.WriteLine("=====================================" + "\n\n");
            Console.WriteLine("\t" + clsMenu.MenuId + "\t" + clsMenu.FoodName + "\t"+ clsMenu.FoodPrice);
            Console.WriteLine("=====================================" + "\n\n");
        }
    }
}