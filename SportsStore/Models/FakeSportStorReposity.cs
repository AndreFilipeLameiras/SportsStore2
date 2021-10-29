using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeSportStorReposity : ISportsStoreReposity
    {
        public IEnumerable<Product> Products => new List<Product>  {
            /* new Product
           {
               Name="Football",
               Price= 25,
           },
           new Product
           {
               Name="Surfboard",
               Price=179
           },
           new Product
           {
               Name="Running Shoes",
               Price=95
           }*/

        };

    }
}
