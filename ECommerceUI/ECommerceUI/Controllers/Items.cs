using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ModelPOCO;

namespace ECommerceUI.Controllers
{
    public class Items
    {
        private int quantity;
        private ShoppingCart shoppingCart;
        private int p;

        public Products prdt = new Products();

        public Products Prdt
        {
            get { return prdt; }
            set { prdt = value; }
        }
       
        public Items()
        {
            
        }

        public Items(Products product, int quantity)
        {
            this.prdt = product;
            this.quantity = quantity;
        }

        public Items(ShoppingCart shoppingCart, int p)
        {
            // TODO: Complete member initialization
            this.shoppingCart = shoppingCart;
            this.p = p;
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}