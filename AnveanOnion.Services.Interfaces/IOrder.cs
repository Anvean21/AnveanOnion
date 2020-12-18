using AnveanOnion.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnveanOnion.Services.Interfaces
{
   public interface IOrder
    {
        void MakeOrder(Product product);
    }
}
