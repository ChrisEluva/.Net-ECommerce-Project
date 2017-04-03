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
    public class ProductRepository : IRepository<Products>
    {
        ECommerceEntities productContext;
        
        //private ECommerceEntities eCommerceEntities;

        public ProductRepository()
        {
            productContext = new ECommerceEntities();  
        }

        public ProductRepository(ECommerceEntities eCommerceEntities)
        {
            this.productContext = eCommerceEntities;
        }

        public List<Products> GetAll()
        {
            List<Products> allProducts = productContext.Products.ToList();
            return allProducts;
        }

        public int Add(Products product)
        {
            productContext.Products.Add(product);
            productContext.SaveChanges();
            return product.ProductsID;
        }

        public Products Update(Products product)
        {
            var productInfo = productContext.Products.Find(product.ProductsID);
            if (productInfo != null)
            {
                productInfo.ProductName = product.ProductName;
                productInfo.SupplierID = product.SupplierID;
                productInfo.Price = product.Price;
                productInfo.QuantityPerUnit = product.QuantityPerUnit;
                productContext.SaveChanges();
  
            }

            return productInfo;
        }

        public void Delete(Products product)
        {
            var productInfo = productContext.Products.Find(product.ProductsID);
            if (productInfo != null)
            {
                productContext.Products.Remove(productInfo);
                productContext.SaveChanges();
            }
        }

        public Products Find(int ID)
        {
            var product = productContext.Products.Find(ID);
            return product;
        }

        //public object Update()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
