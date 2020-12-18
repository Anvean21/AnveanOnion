using AnveanOnion.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnveanOnion.Domain.Interfaces
{
    //Domain Services зависит от Domail model
   public interface IProductRepository: IDisposable
    {
        IEnumerable<Product> GetProductsList();
        Product GetProduct(int id);
        void Create(Product item);
        void Update(Product item);
        void Delete(int id);
        void Save();
    }
}
