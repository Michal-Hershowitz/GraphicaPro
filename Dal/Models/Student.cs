using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class Student : GraphicsWork
    {
        public Student(string name, float price) : base(name, price)
        {
        }
    }
}
