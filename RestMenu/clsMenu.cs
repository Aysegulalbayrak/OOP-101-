using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestMenu
{
    internal class clsMenu
    {
        //Constructor (Yapıcı metod):Yapılandırıcıların (constructor) görevi oluşturulan nesneyi ilk kullanıma hazırlamasıdır.
        //Yapıcı metot sınıf ismiyle aynı olmak zorundadır.
        //Geriye değer döndürmez.Fakat değer döndürmeyen metotlarda kullanılan void yapıcı metotlarda kullanılmaz.
        //Yapıcı metotlar parametre alabilirler, aşırı yüklü olabilirler.
        //

        public clsMenu() //Constructor
        { 
            
        }

        public int MenuId { get; set; } //menudeki ürünün sıra numarası
        public string MenuName { get; set; }
        public string FoodName { get; set; }
        public int FoodPrice { get; set; }
        public int CatId { get; set; }
        
    }
}
