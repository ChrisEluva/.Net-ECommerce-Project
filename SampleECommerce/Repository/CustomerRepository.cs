using ModelPOCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleECommerce;
using System.Data.Entity;


namespace Repository
{
    public class CustomerRepository: IRepository<Customers>

    {
        ECommerceEntities customerContext;
        public virtual object Customers { get; set; }
       // private ECommerceEntities eCommerceEntities;

        public CustomerRepository()
        {
            customerContext = new ECommerceEntities();
        }

        public CustomerRepository(ECommerceEntities eCommerceEntities)
        {
            // TODO: Complete member initialization
            this.customerContext = eCommerceEntities;
        }

        public List<Customers> GetAll()
        {  
            List<Customers> allCustomers = customerContext.Customers.ToList();
            return allCustomers;
        }

        public int Add(Customers customer)
        {
            customerContext.Customers.Add(customer);
            customerContext.SaveChanges();
            return customer.CustomerID;
        }

        public Customers Update(Customers customer)
        {
            var customerInfo = customerContext.Customers.Find(customer.CustomerID);
            if (customerInfo != null)
            {
                customerInfo.FirstName = customer.FirstName;
                customerInfo.LastName = customer.LastName;
                customerInfo.Email = customer.Email;
                customerInfo.Password = customer.Password;
               // customerInfo.Phone = customer.Phone;

            }
            customerContext.SaveChanges();
            return customerInfo;
        }

        public void Delete(Customers customer)
        {
            
            var customerinfo = customerContext.Customers.Find(customer.CustomerID);
            if (customerinfo != null)
            {
                customerContext.Customers.Remove(customerinfo);
                customerContext.SaveChanges();
            }
        }


        public Customers Find(int ID)
        {
            var customer = customerContext.Customers.Find(ID);
            return customer;
        }
    }
}
