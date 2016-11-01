using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class StudentsMain
    {
        static void Main()
        {
            List<Student> allStudents = new List<Student>();

            allStudents.Add(new Student("Ivan", "Petrov", "121206", "0285432143", "petrov@abv.bg", 2, 18));
            allStudents[0].AddMarks(new int[]{2, 2});
            allStudents.Add(new Student("Georgi", "Ivanov", "121205", "0285635143", "ivanov@mail.bg", 51, 20));
            allStudents[1].AddMarks(new int[] { 5, 4, 6 });
            allStudents.Add(new Student("Stanislav", "Cherkezov", "121406", "0882042143", "stancho@gmail.com", 56, 25));
            allStudents[2].AddMarks(new int[] { 6, 4, 6 });
            allStudents.Add(new Student("Tihomir", "Typanarov", "121205", "0885437643", "typanarov@abv.bg", 2, 24));
            allStudents[3].AddMarks(new int[] { 3, 4, 6 });
            allStudents.Add(new Student("Pepe", "Duzparov", "121204", "0885497843", "duzpata@abv.bg", 53, 30));
            allStudents[4].AddMarks(new int[] { 2, 6, 6 });

            
            Console.WriteLine("First before last method!");
            var firstBeforeLastStudents = allStudents.FirstBeforeLast(); //task3
            foreach (var student in firstBeforeLastStudents)
            {
                Console.WriteLine(student.ToString());                
            }

            Console.WriteLine("Age range method!");
            var ageRange = allStudents.AgeRange();  //task4
            foreach (var student in ageRange)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Order by students with LINQ"); //task5
            var orderByLINQ = allStudents.OrderStudentLINQ();
            foreach (var student in orderByLINQ)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Order by students with Lambda"); //task5
            var orderByLambda = allStudents.OrderStudentLambda();
            foreach (var student in orderByLambda)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Ordering student from exact group.(LINQ)");
            var studentFromGroup = allStudents.StudentGroups(); //task9
            foreach (var student in studentFromGroup)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Ordering student from exact group.(Lambda)");
            var studentFromGroupSecond = allStudents.StudentGroupsSecond(); //task10
            foreach (var student in studentFromGroupSecond)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Extracting by mail.(LINQ)");
            var extractingStudentByMail = allStudents.ExtractStudentsByMail(); //task11
            foreach (var student in extractingStudentByMail)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Extracting by phone.(LINQ)");
            var extractingStudentByPhone = allStudents.ExtractByPhone(); //task12
            foreach (var student in extractingStudentByPhone)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Extracting by mark.(LINQ)");
            var extractingStudentByMark = allStudents.ExtractStudentsByMark(); //task13
            foreach (var student in extractingStudentByMark)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Extracting student with exactly two marks");
            var extractingStudenWithTwoF = allStudents.ExtractStudentsByMarkWithTwo(2); //task14
            foreach (var student in extractingStudenWithTwoF)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Marks of student's enrolling in 2006");
            var extractingStudentMarks = allStudents.StudentsIn2006(); //task15
            foreach (var student in extractingStudentMarks)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Grouping by groups. LINQ");
            var groupingByGroups = allStudents.GroupByGroupNumber(); //task18
            foreach (var student in groupingByGroups)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("Grouping by groups. Lambda");
            var groupingByGroupsLambda = allStudents.GroupedByGroupNumberLambda(); //task18
            foreach (var student in groupingByGroupsLambda)
            {
                Console.WriteLine(student.ToString());
            }
        }

        
    }
}
