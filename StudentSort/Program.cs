using System;
using System.Runtime.Intrinsics.Arm;
using Delegates;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>
            {
                new Student
                {
                    Id = 100,
                    Name = "Ram",
                    Age = 15,
                    Score = 99.0
                },
                new Student
                {
                    Id = 121,
                    Name = "Arjun",
                    Age = 19,
                    Score = 89.8
                },
                new Student
                {
                    Id = 101,
                    Name = "Rahul",
                    Age = 15,
                    Score = 99.9
                },
                new Student
                {
                    Id = 102,
                    Name = "Riya",
                    Age = 16,
                    Score = 78.5
                }
            };
            MySort<Student>.BubbleSort(ref StudentList, AscendingOrder<Student>);

            foreach (Student student in StudentList)
            {
                Console.WriteLine($"{student.Name} - {student.Score}");
            }
        }

        public static int AscendingOrder<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b);
        }

        public static int DescendingOrder<T>(T a, T b) where T : IComparable
        {
            return b.CompareTo(a);
        }

    }

}
