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
    public interface ICustomerServices
    {
        [OperationContract]
        List<Customers> GetAllCustomers();

        [OperationContract]
        int AddCustomer(Customers customer);

        [OperationContract]
        void UpdateCustomer(Customers customer);

        [OperationContract]
        void DeleteCustomer(Customers customer);

        [OperationContract]
        Customers FindCustomer(int ID);
    }
}
