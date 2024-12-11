using PetShopProject;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text.Json;




namespace PetShopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = string.Empty;

            //CREATE AN INSTANCE OF OBJECT 'PRODUCTLOGIC'
            var productLogic = new ProductLogic();


            //SAVE USER PRODUCT INPUT
            string productChoice;

                       
            //RUN THIS WHILE INPUT IS NOT "EXIT"
            while (userInput.ToLower() != "exit")
            {
                //ASK USER TO CREATE PRODUCT OR EXIT OR SEARCH
                Console.WriteLine("Type 'exit' to quit.");
                Console.WriteLine("Press '1' to add a product.");
                Console.WriteLine("Press '2' to search for a dog leash");
                Console.WriteLine("Press '3' to search for a cat food");
                Console.WriteLine("Press '8' for total price of inventory");
                Console.WriteLine("Press '9' to search for in-stock products.");
                Console.WriteLine("Press '0' for product list");


                //GET USER INPUT
                userInput = Console.ReadLine();

                //CREATE PRODUCT
                if (userInput == "1")
                {
                    Console.WriteLine("What Product? Choose from: cat food, dog leash...");
                    productChoice = Console.ReadLine();

                    if (productChoice.ToLower() == "cat food")
                    {
                       
                        // "\n" CREATES NEW LINE
                        

                        //Console.WriteLine(JsonSerializer.Serialize(catFood));

                        //'CREATECATFOOD' HAPPENS FIRST BECAUSE IT IS IN THE ( ) LIKE ORDER OF OPERATIONS.
                        //"USE THE INPUT OF 'CREATECATFOOD' HERE"
                        productLogic.AddProduct(CatFood.CreateCatFood());
                        Console.WriteLine("Product has been added.");

                    }
                    else if (productChoice.ToLower() == "dog leash")
                    {

                        //DISPLAY PROPERTIES OF CREATED PRODUCT
                        // "\n" CREATES NEW LINE
                        //Console.WriteLine("Name: " + dogLeash.Name + "\nPrice: " + dogLeash.Price + "\nQuantity: " + dogLeash.Quantity +
                        //    "\nDescription: " + dogLeash.Description + "\nEnter length (inches): " + dogLeash.LengthInches + "\nEnter material: " + dogLeash.Material);

                        productLogic.AddProduct(DogLeash.CreateDogLeash());
                        Console.WriteLine("Product has been added.");

                    }
                    else if (productChoice == "exit") 
                    {
                        System.Environment.Exit(1);


                    }
                    else
                    {
                        Console.WriteLine("Not a valid input.");
                    }




                }
                //SEARCH FOR DOGLEASH
                else if (userInput == "2")  
                {
                    string search;
                    Console.WriteLine("Please enter the name of the dog leash you are looking for.");
                    search = Console.ReadLine();
                    //RESPONSE IS A NEW OBJECT USING DOGLEASH (can this be Product?) AS A BLUEPRINT TO RECIEVE GETDOGLEASHBYNAME
                    DogLeash response = productLogic.GetDogLeashByName(search);
                    //CHECK TO SEE IF PRODUCT CAN BE FOUND
                    if (response == null)
                    {
                        Console.WriteLine("Product not found");
                    }
                    else
                    {
                        //SUPER METHOD?
                        Console.WriteLine("Name: " + response.Name);
                        Console.WriteLine("Price: " + response.Price);
                        Console.WriteLine("Quantity: " + response.Quantity);
                        Console.WriteLine("Description: " + response.Description);
                        Console.WriteLine("Length (inches): " + response.LengthInches);
                        Console.WriteLine("Material: " + response.Material);
                    }
                    

                }
                //SEARCH FOR CATFOOD
                else if (userInput == "3")
                {
                    string search;
                    Console.WriteLine("Please enter the name of the cat food you are looking for.");
                    search = Console.ReadLine();
                    //RESPONSE IS A NEW OBJECT USING DOGLEASH (can this be Product?) AS A BLUEPRINT TO RECIEVE GETDOGLEASHBYNAME
                    CatFood response = productLogic.GetCatFoodByName(search);
                    //CHECK TO SEE IF PRODUCT CAN BE FOUND
                    if (response == null)
                    {
                        Console.WriteLine("Product not found");
                    }
                    else
                    {
                        Console.WriteLine("Name: " + response.Name);
                        Console.WriteLine("Price: " + response.Price);
                        Console.WriteLine("Quantity: " + response.Quantity);
                        Console.WriteLine("Description: " + response.Description);
                        Console.WriteLine("Weight (pounds): " + response.WeightPounds);
                        Console.WriteLine("Kitten food: " + response.IsKittenFood);
                    }

                }
                else if (userInput == "8")
                {
                    Console.WriteLine(productLogic.GetTotalPriceOfInventory());
                    Console.WriteLine("Here is the total inventory price...OF ALL ITEMS: " + productLogic.TheActualPriceOfInventory());
                }
                else if (userInput == "9")
                {
                   

                    List<string> inStock = productLogic.GetOnlyInStockProducts();
                    foreach (var prod in inStock)
                    {


                        Console.WriteLine(prod);



                    }
                    
                    

                }
                else if (userInput == "0")
                {
                    productLogic.GetAllProducts();
                }
                else 
                {
                    Console.WriteLine("Not a valid input.");
                }

                
            }

            System.Environment.Exit(1);
        }
        
    }
    
    
}


