using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOCO;
using Repository;

namespace Services
{
    public class CustomerService: ICustomerServices
    {
        CustomerRepository customerRepository; 
        
        public CustomerService()
        {
            customerRepository = new CustomerRepository();
        }

        public List<Customers> GetAllCustomers()
        {
            List<Customers> allcustomers = customerRepository.GetAll();
            return allcustomers;
        }

        public int AddCustomer(Customers customer)
        {
            int customerId = customerRepository.Add(customer);
            return customerId;
        }

        public void UpdateCustomer(Customers customer)
        {
            customerRepository.Update(customer);
        }

        public void DeleteCustomer(Customers customer)
        {
            customerRepository.Delete(customer);
        }
        public Customers FindCustomer(int ID)
        {
            var customer = customerRepository.Find(ID);
            return customer;
        }
    }
}
