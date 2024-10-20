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
        public string name;
        public decimal price;
        public int quantity;
        public string description;

    }
    class CatFood : Product 
    {
        public double weightPounds;
        public bool kittenFood;
    
    }
    class DogLeash : Product
    {
        public int lengthInches;
        public string material;

    }

}

