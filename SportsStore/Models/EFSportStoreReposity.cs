using SportsStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SportsStore.Models
{
    public class EFSportStoreReposity
    {
        private SportStoreDbContext context;

        public EFSportStoreReposity(SportStoreDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Product> Products => throw new NotImplementedException();
    }
}
