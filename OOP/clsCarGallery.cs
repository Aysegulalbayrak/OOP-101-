using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class clsCarGallery
    {
        public string Brand { get; set; } //Marka
        public string Model { get; set; } //Model
        public string MClass { get; set; } //sınıf (B,C,SUV)
        public int MPower { get; set; } //Motor gücü
        public int MVolume { get; set; } //1400,2000 cc
        public string MSerial { get; set; } //Motor seri no XSDRR454
        public char GasType { get; set; } //Yakıt türü
        public char GearType { get; set; } //Vites türü
        public string CaseType { get; set; } //Kasa tipi
        public int ProducedYear { get; set; } //Üretim yılı
        public string Color { get; set; } // rengi

        public int Price = 3000000;
    }
}
