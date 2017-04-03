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
    public class ShoppingCartRepository : IRepository<ShoppingCart>
    {
        ECommerceEntities cartContext;
        //private ECommerceEntities eCommerceEntities;

        public ShoppingCartRepository()
        {
            cartContext = new ECommerceEntities();
        }

        public ShoppingCartRepository(ECommerceEntities eCommerceEntities)
        {
            // TODO: Complete member initialization
            this.cartContext = eCommerceEntities;
        }

        public List<ShoppingCart> GetAll()
        {
            List<ShoppingCart> cart = cartContext.ShoppingCart.ToList();
            return cart;
        }

        public int Add(ShoppingCart entity)
        {
            cartContext.ShoppingCart.Add(entity);
            cartContext.SaveChanges();
            return entity.ShoppingCartID;  
        }

        public ShoppingCart Find(int ID)
        {
            var cart = cartContext.ShoppingCart.Find(ID);
            return cart;
        }

        public ShoppingCart Update(ShoppingCart entity)
        {
            var updateCart = cartContext.ShoppingCart.Find(entity.ShoppingCartID);
            if (updateCart != null)
            {
                updateCart.ProductName = entity.ProductName;
                updateCart.Quantity = entity.Quantity;
                updateCart.Price = entity.Price;
                updateCart.SubTotal = entity.SubTotal;
                
            }
            cartContext.SaveChanges();
            return updateCart;
        }

        public void Delete(ShoppingCart entity)
        {
           var updateCart = cartContext.ShoppingCart.Find(entity.ShoppingCartID);
           if (updateCart != null)
           {
               cartContext.ShoppingCart.Remove(updateCart);
               cartContext.SaveChanges();
           }
        }
    }
}
