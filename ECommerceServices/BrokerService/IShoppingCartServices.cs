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
    public interface IShoppingCartServices
    {
        [OperationContract]
        List<ShoppingCart> CartGetAll();

        [OperationContract]
        int CartAdd(ShoppingCart entity);

        [OperationContract]
        void UpdateCart(ShoppingCart entity);

        [OperationContract]
        void DeleteCart(ShoppingCart entity);

        [OperationContract]
        ShoppingCart FindCart(int ID);
    }
}
