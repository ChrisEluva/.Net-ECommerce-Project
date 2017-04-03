using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data.Entity;
using ModelPOCO;
using Repository;
using SampleECommerce;


namespace UnitTests
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void Test_GetAll_ReturnsProductsIdOfAllProducts_WhenCalled()
        { 
            //Arrange
            var expected = new List<Products>
            {
                new Products {ProductsID= 1},
                new Products {ProductsID = 2}
            }.AsQueryable();

            var mockSet = new Mock<IDbSet<Products>>();
            mockSet.As<IQueryable<Products>>().Setup(m => m.Provider).Returns(expected.Provider);
            mockSet.As<IQueryable<Products>>().Setup(m => m.Expression).Returns(expected.Expression);
            mockSet.As<IQueryable<Products>>().Setup(m => m.ElementType).Returns(expected.ElementType);
            mockSet.As<IQueryable<Products>>().Setup(m => m.GetEnumerator()).Returns(expected.GetEnumerator());

            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.Products).Returns(mockSet.Object);
            var testClass = new ProductRepository(mockContext.Object);

            //Act
            var actual = testClass.GetAll();

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_GetAll_ReturnsCustomerIDOfAllCustomers_WhenCalled()
        {
            //Arrange
            var expected = new List<Customers>
            {
                new Customers {CustomerID= 1},
                new Customers {CustomerID = 2}
            }.AsQueryable();

            var mockSet = new Mock<IDbSet<Customers>>();
            mockSet.As<IQueryable<Customers>>().Setup(m => m.Provider).Returns(expected.Provider);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.Expression).Returns(expected.Expression);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.ElementType).Returns(expected.ElementType);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.GetEnumerator()).Returns(expected.GetEnumerator());

            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);
            var testClass = new CustomerRepository(mockContext.Object);

            //Act
            var actual = testClass.GetAll();

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_GetAll_ReturnsShoppingCartIdOfAllAvailableCartItems_WhenCalled()
        {
            //Arrange
            var expected = new List<ShoppingCart>
            {
                new ShoppingCart {ShoppingCartID= 1},
                new ShoppingCart {ShoppingCartID = 2}
            }.AsQueryable();

            var mockSet = new Mock<IDbSet<ShoppingCart>>();
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.Provider).Returns(expected.Provider);
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.Expression).Returns(expected.Expression);
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.ElementType).Returns(expected.ElementType);
            mockSet.As<IQueryable<ShoppingCart>>().Setup(m => m.GetEnumerator()).Returns(expected.GetEnumerator());

            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.ShoppingCart).Returns(mockSet.Object);
            var testClass = new ShoppingCartRepository(mockContext.Object);

            //Act
            var actual = testClass.GetAll();

            //Assert
            CollectionAssert.AreEqual(expected, actual);

        }



        [Test]
        public void Test_Update_ReturnsAnUpdatedProductName_WhenCalled()
        {

            //Arrange
            var productList = new List<Products>
            {
                new Products {ProductsID = 1, ProductName="Test", Price=10.50M, QuantityPerUnit = 5, SupplierID = 33}    
            }.AsQueryable();
            
            Products expected =

                new Products { ProductsID = 1, ProductName = "Test2", Price = 11.50M, QuantityPerUnit = 5, SupplierID = 34 };    
            

            var mockSet = new Mock<IDbSet<Products>>();
            mockSet.As<IQueryable<Products>>().Setup(m => m.Provider).Returns(productList.Provider);
            mockSet.As<IQueryable<Products>>().Setup(m => m.Expression).Returns(productList.Expression);
            mockSet.As<IQueryable<Products>>().Setup(m => m.ElementType).Returns(productList.ElementType);
            mockSet.As<IQueryable<Products>>().Setup(m => m.GetEnumerator()).Returns(productList.GetEnumerator());
           
            mockSet.Setup(m => m.Find(It.IsAny<int>())).Returns(productList.FirstOrDefault());

            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.Products).Returns(mockSet.Object);
            var testClass = new ProductRepository(mockContext.Object);
            
            //Act
            var actual = testClass.Update(expected);
            
            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);

        }

        [Test]
        public void Test_Update_ReturnsAnUpdatedCustomerName_WhenCalled()
        {

            //Arrange
            var customerList = new List<Customers>
            {
                new Customers {CustomerID = 1, FirstName="Andrew"}    
            }.AsQueryable();

            Customers expected =

                new Customers { CustomerID = 1, FirstName = "Chris"};


            var mockSet = new Mock<IDbSet<Customers>>();
            mockSet.As<IQueryable<Customers>>().Setup(m => m.Provider).Returns(customerList.Provider);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.Expression).Returns(customerList.Expression);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.ElementType).Returns(customerList.ElementType);
            mockSet.As<IQueryable<Customers>>().Setup(m => m.GetEnumerator()).Returns(customerList.GetEnumerator());

            mockSet.Setup(m => m.Find(It.IsAny<int>())).Returns(customerList.FirstOrDefault());

            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);
            var testClass = new CustomerRepository(mockContext.Object);

            //Act
            var actual = testClass.Update(expected);

            //Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
        }

 
        [Test]
        public void Test_Add_CallsProductsAddMethodOnce_WhenCalled()
        {
            //Arrange
            Products product = new Products();
            var mockSet = new Mock<IDbSet<Products>>();
            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.Products).Returns(mockSet.Object);
            var MockProduct = new ProductRepository(mockContext.Object);
            
            //Act
            MockProduct.Add(product);

            //Assert
            mockSet.Verify(m => m.Add(It.IsAny<Products>()), Times.Once());
            
        }

        [Test]
        public void Test_Add_CallsCustomersAddMethodOnce_WhenCalled()
        {
            //Arrange
            Customers customer = new Customers();
            var mockSet = new Mock<IDbSet<Customers>>();
            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.Customers).Returns(mockSet.Object);
            var MockProduct = new CustomerRepository(mockContext.Object);
           
            //Act
            MockProduct.Add(customer);

            //Assert
            mockSet.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once());

        }


        [Test]
        public void Test_Add_CallsTheShoppingCartAddMethodOnce_WhenCalled()
        {
            //Arrange
            ShoppingCart cart = new ShoppingCart();
            var mockSet = new Mock<IDbSet<ShoppingCart>>();
            var mockContext = new Mock<ECommerceEntities>();
            mockContext.Setup(m => m.ShoppingCart).Returns(mockSet.Object);
            var MockProduct = new ShoppingCartRepository(mockContext.Object);
           
            //Act
            MockProduct.Add(cart);

            //Assert
            mockSet.Verify(m => m.Add(It.IsAny<ShoppingCart>()), Times.Once());

        }

    }
}
