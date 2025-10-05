using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        override public string ToString()
        {
            return $"Id={Id}, Name={Name}, Salary={Salary}";
        }
        override public bool Equals(object? obj)
        {
            if (obj is Employee e)
            {
                return this.Id == e.Id && this.Name == e.Name && this.Salary == e.Salary;
            }
            return false;
        }
        override public int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
