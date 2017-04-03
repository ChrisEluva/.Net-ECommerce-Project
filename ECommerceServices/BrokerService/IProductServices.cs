using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOCO;
using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface IProductServices
    {
        [OperationContract]
        List<Products> GetAllProducts();

        [OperationContract]
        int AddProduct(Products product);

        [OperationContract]
        void UpdateProduct(Products product);

        [OperationContract]
        void DeleteProduct(Products product);

        [OperationContract]
        Products FindProduct(int ID);
    }
}
