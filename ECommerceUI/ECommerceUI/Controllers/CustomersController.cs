using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelPOCO;
using ECommerceUI.CustomersServiceReference;

namespace ECommerceUI.Controllers
{
    public class CustomersController : Controller
    {
        
        CustomerServicesClient customerObject;

        public CustomersController()
        {
            customerObject = new CustomerServicesClient();
        }
        
        // GET: Customers
        public ActionResult Index()
        {
            List<Customers> allCustomers = customerObject.GetAllCustomers().ToList();
            return View(allCustomers);
            //return View();
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            Customers customer = customerObject.FindCustomer(id);
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(Customers customer)
        {
            try
            {
                // TODO: Add insert logic here
                customerObject.AddCustomer(customer);
                {
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            Customers customer = customerObject.FindCustomer(id);
            return View(customer);
            //return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Customers customer)
        {
            try
            {
                // TODO: Add update logic here

                customerObject.UpdateCustomer(customer);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
