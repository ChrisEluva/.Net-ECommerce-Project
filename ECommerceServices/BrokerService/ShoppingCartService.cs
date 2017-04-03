using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOCO;
using Repository;

namespace Services
{

    public class ShoppingCartService: IShoppingCartServices
    {
        ShoppingCartRepository cartRepository;
        
        public ShoppingCartService()
        {
            cartRepository = new ShoppingCartRepository();
        }

        public List<ShoppingCart> CartGetAll()
        {
            List<ShoppingCart> allproducts = cartRepository.GetAll();
            return allproducts;
        }

        public int CartAdd(ShoppingCart entity)
        {
            int product = cartRepository.Add(entity);
            return product;
        }

        public void UpdateCart(ShoppingCart entity)
        {
            cartRepository.Update(entity);
        }

        public void DeleteCart(ShoppingCart entity)
        {
            cartRepository.Delete(entity);
        }

        public ShoppingCart FindCart(int ID)
        {
           var product = cartRepository.Find(ID);
           return product;
        }
    }
}
