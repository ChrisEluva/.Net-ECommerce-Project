using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelPOCO;
using ECommerceUI.ShoppingCartServiceReference;
using ECommerceUI.ProductsServiceReference;


namespace ECommerceUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        ProductServicesClient ShoppingCartObject;
        
        public ShoppingCartController()
        {
            ShoppingCartObject = new ProductServicesClient();
        }
        
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        private int IfExists(int id) 
        {
            List<Items> cart = (List<Items>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].prdt.ProductsID == id)
                    return i;
            return -1;
        }

        public ActionResult Delete(int id)
        {
            int ID = IfExists(id);
            List<Items> ItemsCart = (List<Items>)Session["cart"];
            //ItemsCart.RemoveAt(ID);
             
            if (ItemsCart[ID].Quantity == 1)
            {
                ItemsCart.RemoveAt(ID);
            }
            else if (ItemsCart[ID].Quantity >= 1)
            {
                ItemsCart[ID].Quantity--;
            }                   

            Session["cart"] = ItemsCart;
            Logger.WriteToLog(DateTime.Now + " Product deleted from cart");
            return View("Cart");
        }

        public ActionResult Cart(int id)
        {
            if (Session["cart"] == null)
            {
                List<Items> ItemsCart = new List<Items>();
                ItemsCart.Add(new Items(ShoppingCartObject.FindProduct(id), 1));
                Session["cart"] = ItemsCart;
            }
            else
                 
            {
                List<Items> ItemsCart = (List<Items>)Session["cart"];
                int ID = IfExists(id);
                if (ID == -1)
                    ItemsCart.Add(new Items(ShoppingCartObject.FindProduct(id), 1));
                else
                    ItemsCart[ID].Quantity++;
                Session["cart"] = ItemsCart;
            }

            Logger.WriteToLog(DateTime.Now + " Product added to cart");
            return View("Cart");
        }


      
    }
}
