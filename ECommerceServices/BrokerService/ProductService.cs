using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelPOCO;
using Repository;

namespace Services
{
    public class ProductService : IProductServices
    {
        ProductRepository productRepository; 

        public ProductService()
        {
            productRepository = new ProductRepository();
        }

        public List<Products> GetAllProducts()
        {
            List<Products> allproducts = productRepository.GetAll();
            return allproducts;
        }

        public int AddProduct(Products product)
        {
            int ProductsID = productRepository.Add(product);
            return ProductsID;
        }

        public void UpdateProduct(Products product)
        {
            productRepository.Update(product);
        }

        public void DeleteProduct(Products product)
        {
            productRepository.Delete(product);
        }

        public Products FindProduct(int ID)
        {
            var product = productRepository.Find(ID);
            return product;
        }
    }
}
