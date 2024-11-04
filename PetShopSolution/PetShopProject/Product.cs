using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

    }
    public class CatFood : Product 
    {
        public double WeightPounds { get; set; }
        public bool IsKittenFood { get; set; }


        //STATIC: NOT CHANGING. USABLE EVEN IF THERE IS NO INSTANCE OF THE CLASS (AN OBJECT).
        //NON-STATIC (DEFULT OPTION): DEPENDANT ON AN OBJECT. HAS TO HAVE AN INSTANCE
        //BLUEPRINT IS THE CLASS
        //INSTANCE IS THE OBJECT
        public static CatFood CreateCatFood() 
        {
            Console.WriteLine("New cat food: ");
            CatFood catFood = new CatFood();
            //name price quantity description kitten weightPounds
            Console.WriteLine("Enter name: ");
            catFood.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            catFood.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity: ");
            catFood.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter description: ");
            catFood.Description = Console.ReadLine();
            Console.WriteLine("Kitten food (true or false): ");
            catFood.IsKittenFood = bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter weight (Pounds): ");
            catFood.WeightPounds = double.Parse(Console.ReadLine());

            return catFood;
        }

    }
    public class DogLeash : Product
    {
        public int LengthInches { get; set; }
        public string Material { get; set; }

        public static DogLeash CreateDogLeash()
        {
            Console.WriteLine("New dog leash.");
            DogLeash dogLeash = new DogLeash();
            //name price quantity description lengthInches material
            Console.WriteLine("Enter name: ");
            dogLeash.Name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            dogLeash.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter quantity: ");
            dogLeash.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter description: ");
            dogLeash.Description = Console.ReadLine();
            Console.WriteLine("Enter length (inches): ");
            dogLeash.LengthInches = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter material: ");
            dogLeash.Material = Console.ReadLine();

            return dogLeash;

        }

    }

   
   
  

    


}

