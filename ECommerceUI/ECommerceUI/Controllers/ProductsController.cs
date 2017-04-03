using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelPOCO;
using ECommerceUI.ProductsServiceReference;

namespace ECommerceUI.Controllers
{
    public class ProductsController : Controller
    {
        ProductServicesClient productObject;

        public ProductsController()
        {
            productObject = new ProductServicesClient();
        }
        // GET: Products
        public ActionResult Index()
        {
            List<Products> allProducts = productObject.GetAllProducts().ToList();
            return View(allProducts);
            //return View();
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            Products product = productObject.FindProduct(id);
            return View(product);

        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(Products product)
        {
            try
            {
                // TODO: Add insert logic here
                productObject.AddProduct(product);
                {
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            Products product = productObject.FindProduct(id);
            return View(product);
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Products product)
        {
            try
            {
                // TODO: Add update logic here
                productObject.UpdateProduct(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
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
