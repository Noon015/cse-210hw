using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list1 = new List<Product>();
        Address address1 = new Address("123 Easy St.", "Intercourse", "Pennsylvania","USA");
        //This is a real city in Pennsylvania. Interesting yeah?
        Customer customer1 = new Customer("Neal","Shusterman",address1);
        Order order1 = new Order(customer1,list1);
        Product product1 = new Product("eggs",0,3.00m,2);
        Product product2 = new Product("milk",1,2.00m,3);
        Product product3 = new Product("butter",2,4.00m,1);

        order1.AddToOrder(product1);
        order1.AddToOrder(product2);
        order1.AddToOrder(product3);
        decimal customerTotal1 = order1.CalculateOrder();
        order1.DisplayCustomerInfo();
        order1.DisplayProducts();
        Console.WriteLine($"Your total for today: {customerTotal1}");
        Console.WriteLine("_____________________________________________________________________\n\n");

        
        List<Product> list2 = new List<Product>();
        Address address2 = new Address("Gustav Eiffel Ave.","Paris","Centre","France");
        //Address of the Eiffel Tower in Paris
        Customer customer2 = new Customer("Louis","Oui",address2);
        Order order2 = new Order(customer2,list2);
        Product product4 = new Product("bread",3,7.00m,2);
        Product product5 = new Product("cheese",4,12.00m,4);
        Product product6 = new Product("wine",5,20.00m,1);

        order2.AddToOrder(product4);
        order2.AddToOrder(product5);
        order2.AddToOrder(product6);
        decimal customerTotal2 = order2.CalculateOrder();
        order2.DisplayCustomerInfo();
        order2.DisplayProducts();
        Console.WriteLine($"Your total for today: {customerTotal2}");


    }
}