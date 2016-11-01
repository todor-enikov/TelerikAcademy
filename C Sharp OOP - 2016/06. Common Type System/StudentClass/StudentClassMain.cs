using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class StudentClassMain
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Karlito", "Ivanov", 123212434, "ul.Makedonska", 0885433154, "shturec@abv.bg", 2, enumSpecialities.Mehatronics, enumUniversities.UNWE, enumFaculties.MechanicalFaculty));
            students.Add(new Student("Chicho", "Iliq", "Petkov", 873206934, "ul.Strandja", 0865433524, "golqm_shturec@abv.bg", 4, enumSpecialities.SSS, enumUniversities.UASG, enumFaculties.SSSFaculty));

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Comparing students direct with the overriden method Equals.");
            var comparingStudentsEquals = Equals(students[0], students[1]);
            Console.WriteLine("{0}\n", comparingStudentsEquals);

            Console.WriteLine("Comparing students direct with the == operator method.");
            var comparingWithFirstOperator = Student.Equals(students[0], students[1]);
            Console.WriteLine("{0}\n", comparingWithFirstOperator);

            Console.WriteLine("Comparing students direct with the != operator method.");
            var comparingWithSecondOperator = !Student.Equals(students[0], students[1]);
            Console.WriteLine("{0}\n", comparingWithSecondOperator);

            Console.WriteLine("Using GetHashCode method.");
            var getHashCodeFirst = students[0].GetHashCode();
            var getHashCodeSecond = students[1].GetHashCode();

            Console.WriteLine("HashCode for first student {0}", getHashCodeFirst);
            Console.WriteLine("HashCode for second student {0}\n", getHashCodeSecond);

            Console.WriteLine("Cloning a student."); //task2
            var clonedStudent = students[0].Clone();
            Console.WriteLine(clonedStudent);

            Console.WriteLine("IComparable:");  //task3
            var comparingStudents = students[0].CompareTo(students[1]);
            if (comparingStudents<0)
            {
                Console.WriteLine("Students are with different names: {0} and {1}",students[0].FirstName,students[1].FirstName);
            }
            else 
            {
                Console.WriteLine("Students are with same names: {0} and {1}", students[0].FirstName, students[1].FirstName);                
            }

        }
    }
}
