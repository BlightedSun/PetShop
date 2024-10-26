using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject
{
    public class Product
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }

    }
    public class CatFood : Product 
    {
        public double weightPounds { get; set; }
        public bool IsKittenFood { get; set; }
    
    }
    public class DogLeash : Product
    {
        public int lengthInches { get; set; }
        public string material { get; set; }

    }

}

