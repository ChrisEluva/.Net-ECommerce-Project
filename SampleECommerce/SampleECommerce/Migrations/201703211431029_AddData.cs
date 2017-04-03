namespace SampleECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(FirstName, LastName,Email, Password, Phone) VALUES ('John', 'Smith', 'johnsmith22@gmail.com', 'johnpassword', '9783100')");
            Sql("INSERT INTO Customers(FirstName, LastName,Email, Password, Phone) VALUES ('Ben', 'King', 'benking10@gmail.com', 'benpassword', '9783101')");
            Sql("INSERT INTO Customers(FirstName, LastName,Email, Password, Phone) VALUES ('Paul', 'Turner', 'paulturner@outlook.com', 'paulpassword', '9783102')");
            Sql("INSERT INTO Customers(FirstName, LastName,Email, Password, Phone) VALUES ('Michael', 'Long', 'michaellong@yahoo.com', 'michaelpassword', '9783103')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Customers WHERE FirstName = 'John' AND LastName = 'Smith' AND Email = 'johnsmith22@gmail.com' AND Password = 'johnpassword' AND Phone = '9783100'");
            Sql("DELETE FROM Customers WHERE FirstName = 'Ben' AND LastName = 'King' AND Email = 'benking10@gmail.com' AND Password = 'benpassword' AND Phone = '9783101'");
            Sql("DELETE FROM Customers WHERE FirstName = 'Paul' AND LastName = 'Turner' AND Email = 'paulturner@outlook.com' AND Password = 'paulpassword' AND Phone = '9783102'");
            Sql("DELETE FROM Customers WHERE FirstName = 'Michael' AND LastName = 'Long' AND Email = 'michaellong@yahoo.com' AND Password = 'michaelpassword' AND Phone = '9783103'");


        }

    }
}
