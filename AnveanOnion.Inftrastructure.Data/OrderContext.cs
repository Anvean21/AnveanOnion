using AnveanOnion.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnveanOnion.Inftrastructure.Data
{
    public class OrderContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
