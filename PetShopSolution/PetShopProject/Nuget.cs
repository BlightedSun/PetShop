using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject
{
    internal class Nuget
    {

        IServiceProvider serviceCollection = CreateServiceCollection();
        ProductLogic productLogic = serviceCollection.GetService<IProductLogic>();
        static IServiceProvider CreateServiceCollection()
        {
            //passing ProductLogic as a generic service
            return new ServiceCollection()
                .AddTransient<IProductLogic, ProductLogic>()
                .BuildServiceProvider();
        }


    }
}
