using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject
{
    public static class ListExtentions
    {

        
            

        //'T' means its something. dont know what yet. but it will be a list in this case. InStock is the name of the method. this List named 'list'. where T inherits from Product
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(x => x.Quantity > 0).ToList();


        }





    }







    
}
