using AnveanOnion.Domain.Core;
using AnveanOnion.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnveanOnion.Infrastructure.Business
{
    public class CreditOrder : IOrder
    {
        public void MakeOrder(Product product)
        {
            //Код покупки продукта с помощью карты
            throw new NotImplementedException();
        }
    }
}
