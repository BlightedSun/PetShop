using PetShopProject;
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


                //GET USER INPUT
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("What Product? Choose from: cat food, dog leash...");
                    productChoice = Console.ReadLine();

                    if (productChoice.ToLower() == "cat food")
                    {
                        //DISPLAY PROPERTIES OF CREATED PRODUCT
                        // "\n" CREATES NEW LINE
                        //Console.WriteLine("Name: " + catFood.name + "\nPrice: " + catFood.price + "\nQuantity: " + catFood.quantity + 
                        //    "\nDescription: " + catFood.description + "\nKitten food: " + catFood.kittenFood + "\nWeight (Pounds): " + catFood.weightPounds);

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

            System.Environment.Exit(1);
        }
        
    }
    
    
}


