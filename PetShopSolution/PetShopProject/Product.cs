using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject
{
    class Product
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }

    }
    class CatFood : Product 
    {
        public double weightPounds { get; set; }
        public bool kittenFood { get; set; }
    
    }
    class DogLeash : Product
    {
        public int lengthInches { get; set; }
        public string material { get; set; }

    }

}

