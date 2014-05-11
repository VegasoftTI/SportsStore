using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.Domain.Concrete;

namespace SportsStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            #region Mock object
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> { 
                new Product { Name = "Football", Price = 25, Category = "Sport" },
                new Product { Name = "Surf board", Price = 179, Category = "Sport" },
                new Product { Name = "Running shoes", Price = 95, Category = "Sport" }
            });
            //kernel.Bind<IProductRepository>().ToConstant(mock.Object);
            #endregion

            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}