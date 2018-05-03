using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.Entities
{
    public class Diem
    {
        // 1. Khai bao cac thuoc tinh va get-set trong class Diem
        public int X { get; set; }
        public int Y { get; set; }

        //2. Khai bao constructor ko tham so va ham create co day du tham so
        public Diem()
        {
            Console.WriteLine("Constructor class DIEM khong tham so");
        }

        public Diem(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap so X: ");
                this.X = Convert.ToInt32(Console.ReadLine());

            } while (this.X < -2000 || this.X > 2000);

            do
            {
                Console.WriteLine("Nhap so Y: ");
                this.Y = Convert.ToInt32(Console.ReadLine());
            } while (this.Y > 2000 || this.Y < -2000);
        }

        public void Xuat()
        {
            Console.WriteLine("X: " + this.X + ",Y: " + this.Y);
        }

        public double DoDai(Diem b)
        {
            return Math.Sqrt((this.X - b.X) * (this.X - b.X) + (this.Y - b.Y) * (this.Y - b.Y));
        }

    }


}
