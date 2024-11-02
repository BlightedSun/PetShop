﻿using System;
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
        Dictionary<string, DogLeash> _dogLeashes = new Dictionary<string, DogLeash>();
        Dictionary<string, CatFood> _catFoods = new Dictionary<string, CatFood>();


        //CREATING AN INSTANCE (CONSTRUCTOR) OF 'PRODUCTLOGIC' CLASS
        public ProductLogic()
        {
            _products = new List<Product>();


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




        //METHOD TO LIST ALL PRODUCTS
        List<Product> GetAllProducts()
        {
            return _products;
        }



    }

    

}
