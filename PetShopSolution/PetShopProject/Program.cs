using System;
using System.ComponentModel.Design;
using System.Text.Json;

namespace PetShopProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //ASK USER TO CREATE PRODUCT OR EXIT
            Console.WriteLine("Press '1' to add a product.");
            Console.WriteLine("Type 'exit' to quit.");

            //GET USER INPUT
            string userInput = Console.ReadLine();

            //SAVE USER PRODUCT INPUT
            string productChoice;

            //METHOD TO CREATE PRODUCT
            void CreateProduct(string productChoice)
            { 
            
            }
            
            //RUN THIS WHILE INPUT IS NOT "EXIT"
            while (userInput.ToLower() != "exit")
            {
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
                        catFood.name = Console.ReadLine();
                        Console.WriteLine("Enter price: ");
                        catFood.price = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter quantity: ");
                        catFood.quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter description: ");
                        catFood.description = Console.ReadLine();
                        Console.WriteLine("Kitten food (true or false): ");
                        catFood.kittenFood = bool.Parse(Console.ReadLine());
                        Console.WriteLine("Enter weight (Pounds): ");
                        catFood.weightPounds = double.Parse(Console.ReadLine());

                        //DISPLAY PROPERTIES OF CREATED PRODUCT
                        // "\n" CREATES NEW LINE
                        //Console.WriteLine("Name: " + catFood.name + "\nPrice: " + catFood.price + "\nQuantity: " + catFood.quantity + 
                        //    "\nDescription: " + catFood.description + "\nKitten food: " + catFood.kittenFood + "\nWeight (Pounds): " + catFood.weightPounds);
                        Console.WriteLine(JsonSerializer.Serialize(catFood));

                    }
                    else if (productChoice.ToLower() == "dog leash")
                    {
                        Console.WriteLine("New dog leash.");
                        DogLeash dogLeash = new DogLeash();
                        //name price quantity description lengthInches material
                        Console.WriteLine("Enter name: ");
                        dogLeash.name = Console.ReadLine();
                        Console.WriteLine("Enter price: ");
                        dogLeash.price = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Enter quantity: ");
                        dogLeash.quantity = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter description: ");
                        dogLeash.description = Console.ReadLine();
                        Console.WriteLine("Enter length (inches): ");
                        dogLeash.lengthInches = int.Parse(Console.ReadLine());
                        Console.WriteLine(" : ");
                        dogLeash.material = Console.ReadLine();

                        //DISPLAY PROPERTIES OF CREATED PRODUCT
                        // "\n" CREATES NEW LINE
                        Console.WriteLine("Name: " + dogLeash.name + "\nPrice: " + dogLeash.price + "\nQuantity: " + dogLeash.quantity + 
                            "\nDescription: " + dogLeash.description + "\nEnter length (inches): " + dogLeash.lengthInches + "\nEnter material: " + dogLeash.material);
                    }
                   



                }



                Console.WriteLine("Press '1' to add a product.");
                Console.WriteLine("Type 'exit' to quit.");
                userInput = Console.ReadLine();
            }
           
        }
    }
    
    
}


