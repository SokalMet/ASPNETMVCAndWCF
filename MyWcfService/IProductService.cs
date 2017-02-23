using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace MyWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        List<Product> findAll();

        [OperationContract]
        List<Product> find (int id);

        [OperationContract]
        List<Product> findByDate(DateTime CreationDate);

    }
}
