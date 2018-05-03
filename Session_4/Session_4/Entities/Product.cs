using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }

        /*Contructor: 
         - luon luon la public,
         - ko co kieu du lieu(int, string, double, void...)
         - ten constructor = ten class\
         - co nhiu constructor trong 1 class (phan biet thong qua so luong tham so va kieu du lieu cua tham so)
         => Muc dich: khoi gan' gia tri cho attribute cua object khi object vua dc tao ra
         */
        public Product()
        {
            Console.WriteLine("Constructor khong tham so");
        }
        public Product(string Id)
        {
            Console.WriteLine("Constructor 1 tham so ID");
        }
        public Product(double Price)
        {
            Console.WriteLine("Constructor 1 tham so Price");
        }
        public Product(string Id, string Name, double Price, int Quantity, bool Status)
        {
            //this.ID chinh la product5
            //ID chinh la tham so ID tren constructor
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Status = Status;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine("Quantity: " + this.Quantity);
            Console.WriteLine("Status: " + this.Status);
        }

        public void Create()
        {
            Console.WriteLine("Add Prodcut");
        }

        public bool Check(string id)
        {
            return id == "p01";
        }

    }
}
