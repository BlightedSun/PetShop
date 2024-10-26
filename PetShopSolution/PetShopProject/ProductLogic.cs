using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject
{
    public class ProductLogic
    {


        //ADD A NEW PRIVATE VARIABLE CALLED '_PRODUCTS' TYPE LIST. THE UNDERSCORE MEANS ITS PRIVATE.
        List<Product> _products;

        //CREATING DICTIONARIES FOR THE CREATED ITEMS
        Dictionary<string, DogLeash> _dogKLeashes;
        Dictionary<string, CatFood> _catFood;


        //CREATING AN INSTANCE (CONSTRUCTOR) OF 'PRODUCTLOGIC' CLASS
        public ProductLogic()
        {
            _products = new List<Product>();


        }

        //METHOD TO ADD PRODUCT
        public void AddProduct(Product product) 
        {
            _products.Add(product);
        }

        //METHOD TO LIST ALL PRODUCTS
        List<Product> GetAllProducts()
        {
            return _products;
        }



    }

    

}
