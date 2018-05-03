using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4
{
    public class Student
    {
        //public, protected, private
        public string Id;
        public string Name;
        public string Address;
        public string Email { get; set; }
        private double math;
        public double Math
        {
            get // tra gia tri tu ve cho attribute
            {
                return this.math;
            }
            set // gan gia tri cho thuoc tinh_attribute
            {
                if(value > 10 || value < 0)
                {
                    this.math = 0;
                }
                else
                {
                    this.math = value;
                }

                
            }
        }


    }
}
