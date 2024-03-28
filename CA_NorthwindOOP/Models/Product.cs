using System;
using CA_NorthwindOOP.Abstracts;

namespace CA_NorthwindOOP.Models 
{
    public class Product:BaseClass
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"{ProductName}  -  Id: {Id}  -  Birim Fiyat : {UnitPrice}  -  Stok Adedi : {Stock}";
        }
    }

}


