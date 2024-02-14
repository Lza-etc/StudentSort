using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Student: IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Score { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (!(obj is Student))
                throw new ArgumentException("Object is not a Student", nameof(obj));

            Student otherStudent = (Student)obj;
            return Score.CompareTo(otherStudent.Score);
        }
    }
}
