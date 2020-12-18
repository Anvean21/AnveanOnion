using AnveanOnion.Domain.Core;
using AnveanOnion.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AnveanOnion.Inftrastructure.Data
{
   public class ProductRepository : IProductRepository
    {
        private OrderContext db;
        public ProductRepository()
        {
            this.db = new OrderContext();
        }
        public void Create(Product item)
        {
            db.Products.Add(item);
        }

        public void Delete(int id)
        {
            Product product = db.Products.Find(id);
            if (product != null)
            {
                db.Products.Remove(product);
            }
        }
        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Product GetProduct(int id)
        {
            return db.Products.Find(id);
        }

        public IEnumerable<Product> GetProductsList()
        {
            return db.Products.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Product item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
