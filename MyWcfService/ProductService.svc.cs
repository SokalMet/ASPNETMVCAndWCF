using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductService.svc or ProductService.svc.cs at the Solution Explorer and start debugging.
    public class ProductService : IProductService
    {
        private MyDemoEntities mde = new MyDemoEntities();

        public List<Product> find(int id)
        {
            return mde.Product.Where(p=>p.Id==id).ToList();
        }

        public List<Product> findAll()
        {
            return mde.Product.ToList();
        }

        public List<Product> findByDate(DateTime CreationDate)
        {
            return mde.Product.Where(p=>p.CreationDate.Value==CreationDate).ToList();
        }
    }
}
