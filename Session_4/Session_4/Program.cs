using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_4.Entities;

namespace Session_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo6();
            Console.ReadLine();
        }

        static void Demo1()
        {
            Student student1 = new Student();
            student1.Id = "st01";
            student1.Name = "Name 1";
            student1.Address = "Address 1";
            student1.Math = 7;
            student1.Email = "Jasonle@gmail.com";

            Console.WriteLine("Student 1 Info");
            Console.WriteLine("\nID: " + student1.Id);
            Console.WriteLine("Name:  " + student1.Name);
            Console.WriteLine("Address: " + student1.Address);
            Console.WriteLine("Math: " + student1.Math);
            Console.WriteLine("Email: " + student1.Email);
        }

        static void Demo2()
        {
            Product product = new Product();
            Console.Write("Input ID: ");
            product.Id = Console.ReadLine();
            Console.Write("Input Name: ");
            product.Name = Console.ReadLine();
            Console.Write("Input Price: ");
            product.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input Quantity: ");
            product.Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Status: ");
            product.Status = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nProduct info:");
            Console.WriteLine("ID: " + product.Id);
            Console.WriteLine("Name: " + product.Name);
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Quantity: " + product.Quantity);
            Console.WriteLine("Status: " + product.Status);
        }

        static void Demo3()
        {
            var product = new Product() { Id = "p01", Name = "Name 1", Price = 10, Quantity = 20, Status = true };
            Console.WriteLine("\nProduct info:");
            Console.WriteLine("ID: " + product.Id);
            Console.WriteLine("Name: " + product.Name);
            Console.WriteLine("Price: " + product.Price);
            Console.WriteLine("Quantity: " + product.Quantity);
            Console.WriteLine("Status: " + product.Status);
        }

        static void Demo4()
        {
            var product = new Product();
            product.Create();
            Console.WriteLine(product.Check("abc"));
        }

        static void Demo5()
        {
            var product1 = new Product();
            var product2 = new Product();
            var product3 = new Product("o03");
            var product4 = new Product(5.6);
            var product5 = new Product("p01", "Name 1", 5, 3, true);
            var product6 = new Product("p02", "Name 2", 2, 7, false);

            /*Console.WriteLine("\nProduct 5 Info:");
            Console.WriteLine("ID: " + product5.Id);
            Console.WriteLine("Name: " + product5.Name);
            Console.WriteLine("Price: " + product5.Price);
            Console.WriteLine("Quantity: " + product5.Quantity);
            Console.WriteLine("Status: " + product5.Status);

            Console.WriteLine("\nProduct 6 Info:");
            Console.WriteLine("ID: " + product6.Id);
            Console.WriteLine("Name: " + product6.Name);
            Console.WriteLine("Price: " + product6.Price);
            Console.WriteLine("Quantity: " + product6.Quantity);
            Console.WriteLine("Status: " + product6.Status);
             */
            Console.WriteLine("\nProduct 5 Info:");
            product5.Display();
        }

        static void Demo6()
        {
            var diem1 = new Diem();
            diem1.Nhap();
        }

    }
}
