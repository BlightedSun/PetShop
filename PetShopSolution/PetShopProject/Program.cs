﻿using PetShopProject;
using System;
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

            //ASK USER TO CREATE PRODUCT OR EXIT
            //Console.WriteLine("Press '1' to add a product.");
            //Console.WriteLine("Type 'exit' to quit.");
            //Console.WriteLine("Press '2' to search for product");
                              
            
            //GET USER INPUT
           //userInput = Console.ReadLine();

            //SAVE USER PRODUCT INPUT
            string productChoice;

            //METHOD TO CREATE PRODUCT
            //void CreateProduct(string productChoice)
            //{ 
            //
            //}
            
            //RUN THIS WHILE INPUT IS NOT "EXIT"
            while (userInput.ToLower() != "exit")
            {
                //ASK USER TO CREATE PRODUCT OR EXIT OR SEARCH
                Console.WriteLine("Type 'exit' to quit.");
                Console.WriteLine("Press '1' to add a product.");
                Console.WriteLine("Press '2' to search for a dog leash");
                Console.WriteLine("Press '3' to search for a cat food");


                //GET USER INPUT
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("What Product? Choose from: cat food, dog leash...");
                    productChoice = Console.ReadLine();

                    if (productChoice.ToLower() == "cat food")
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

                        //DISPLAY PROPERTIES OF CREATED PRODUCT
                        // "\n" CREATES NEW LINE
                        //Console.WriteLine("Name: " + catFood.name + "\nPrice: " + catFood.price + "\nQuantity: " + catFood.quantity + 
                        //    "\nDescription: " + catFood.description + "\nKitten food: " + catFood.kittenFood + "\nWeight (Pounds): " + catFood.weightPounds);

                        //Console.WriteLine(JsonSerializer.Serialize(catFood));


                        productLogic.AddProduct(catFood);
                        Console.WriteLine("Product has been added.");

                    }
                    else if (productChoice.ToLower() == "dog leash")
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

                        //DISPLAY PROPERTIES OF CREATED PRODUCT
                        // "\n" CREATES NEW LINE
                        //Console.WriteLine("Name: " + dogLeash.Name + "\nPrice: " + dogLeash.Price + "\nQuantity: " + dogLeash.Quantity +
                        //    "\nDescription: " + dogLeash.Description + "\nEnter length (inches): " + dogLeash.LengthInches + "\nEnter material: " + dogLeash.Material);

                        productLogic.AddProduct(dogLeash);
                        Console.WriteLine("Product has been added.");

                    }
                    else
                    {
                        Console.WriteLine("Not a valid input.");
                    }




                }
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
                        Console.WriteLine("Name: " + response.Name);
                        Console.WriteLine("Price: " + response.Price);
                        Console.WriteLine("Quantity: " + response.Quantity);
                        Console.WriteLine("Description: " + response.Description);
                        Console.WriteLine("Length (inches): " + response.LengthInches);
                        Console.WriteLine("Material: " + response.Material);
                    }
                    

                }
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
                else 
                {
                    Console.WriteLine("Not a valid input.");
                }

                
            }
           
        }
    }
    
    
}


