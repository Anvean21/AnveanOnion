using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnveanOnion.Domain.Interfaces;
using AnveanOnion.Services.Interfaces;
using AnveanOnion.Infrastructure.Business;
using AnveanOnion.Inftrastructure.Data;
using Ninject.Modules;

namespace AnveanOnion.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<IOrder>().To<CacheOrder>();
        }
    }
}