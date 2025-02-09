﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject
{
    



    public class ProductLogic : IProductLogic
    {


        //ADD A NEW PRIVATE VARIABLE CALLED '_PRODUCTS' TYPE LIST. THE UNDERSCORE MEANS ITS PRIVATE.
        List<Product> _products;

        //CREATING DICTIONARIES FOR THE CREATED ITEMS
        Dictionary<string, DogLeash> _dogLeashes = new Dictionary<string, DogLeash>();
        Dictionary<string, CatFood> _catFoods = new Dictionary<string, CatFood>();





        //CREATING AN INSTANCE (CONSTRUCTOR) OF 'PRODUCTLOGIC' CLASS
        public ProductLogic()
        {
            _products = new List<Product>();
            AddProduct(new DogLeash { Name = "Leather Leash", Price = 3, Quantity = 5, Description = "Not the best...", LengthInches = 24, Material = "Leather" });
            AddProduct(new DogLeash { Name = "Glitter Leash", Price = 5, Quantity = 0, Description = "The best!", LengthInches = 24, Material = "Glitter" });
            AddProduct(new CatFood { Name = "Mert Chow", Price = 100, Quantity = 2, Description = "Only the best for the boy!", WeightPounds = 21, IsKittenFood = false });


        }

        //METHOD TO ADD PRODUCT
        //ACCESS IS PUBLIC, RETURN VOID, NAME, ???
        public void AddProduct(Product product)
        {
            _products.Add(product);

            //IF PRODUCT IS DOGLEASH, THEN ADD TO DOGLEASH DICTIONARY
            //PRODUCT.NAME IS THE KEY FOR DICTIONARY. IT IS LIKE A SERIAL NUMBER FOR THE ITEM
            if (product is DogLeash)
            {
                _dogLeashes.Add(product.Name, product as DogLeash);
            }
            else if (product is CatFood)
            {
                _catFoods.Add(product.Name, product as CatFood);
            }
            else
            {


            }


        }


        /*
         * ACCESS MODIFIER 'PUBLIC', RETURN TYPE (WHAT WE GET OUT OF IT) 'DOGLEASH', METHOD NAME 'GETDOGLEASHBYNAME',
         * PARAMETER (INPUT) (WHAT THE METHOD EXPECTS TO RECIEVE) 'STRING NAME'.
        */
        public DogLeash GetDogLeashByName(string name)
        {
            try
            {
                return _dogLeashes[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public CatFood GetCatFoodByName(string name)
        {
            try
            {
                return _catFoods[name];
            }
            catch (Exception ex)
            {
                return null;
            }
        }




        //METHOD TO LIST ALL PRODUCTS. USING THE PRODUCT LIST, GO THROUGH EACH PRODUCT TYPE AND PRINT OUT INFO
        public void GetAllProducts()
        {

        
            foreach (CatFood product in _products.OfType<CatFood>())
            {
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Description: " + product.Description);
                Console.WriteLine("Weight (pounds): " + product.WeightPounds);
                Console.WriteLine("Kitten food: " + product.IsKittenFood);
            }


        

            foreach (DogLeash product in _products.OfType<DogLeash>())
            {
                Console.WriteLine("Name: " + product.Name);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Quantity: " + product.Quantity);
                Console.WriteLine("Description: " + product.Description);
                Console.WriteLine("Length (inches): " + product.LengthInches);
                Console.WriteLine("Material: " + product.Material);

            }
        }
        //SHOWS PRODUCTS WITH QUANTITY GREATER THAN 0
        //_products.Where(method placeholder => definition of the method).collection
        public List<string> GetOnlyInStockProducts()
        {
            
            return _products.InStock().Select(x => x.Name).ToList();
            
        }


        
        


        
        public decimal GetTotalPriceOfInventory()
        {


            return _products.InStock().Select(x => x.Price).Sum();

        }

        public decimal TheActualPriceOfInventory()
        {
            List<Product> inventory = _products.InStock();

            decimal totalCost = 0;

            //get list of products. for each product multiply quantity * price. then add the total cost
            foreach (var product in _products)
            {
                totalCost += (product.Quantity * product.Price);

            }
            return totalCost;
        }




    }

   


    //INTERFACE TELLS WHAT THE CLASS/METHOD SHOULD INCLUDE, BUT THE CLASS/METHOD ITSELF DEFINES HOW TO USE WHAT IS IN IT.
    interface IProductLogic
    {
         public void AddProduct(Product product);
         public void GetAllProducts(); 
         public DogLeash GetDogLeashByName(string name);
         public List<string> GetOnlyInStockProducts();  
        public decimal GetTotalPriceOfInventory();
        public decimal TheActualPriceOfInventory();
        public CatFood GetCatFoodByName(string name);

    }
    
}



