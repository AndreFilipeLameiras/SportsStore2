using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class ISportsStoreReposity
    {
        public IEnumerable<Product> Products { get; }
    }
}
