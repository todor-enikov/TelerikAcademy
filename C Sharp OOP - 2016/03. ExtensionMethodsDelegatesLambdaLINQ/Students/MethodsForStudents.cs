using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public static class MethodsForStudents
    {
        public static IEnumerable<T> FirstBeforeLast<T>(this IEnumerable<T> students) where T : Student //task3
        {
            var result = from student in students
                         where student.FirstName.CompareTo(student.LastName) < 0
                         select student;

            return result;
        }

        public static IEnumerable<T> AgeRange<T>(this IEnumerable<T> students) where T : Student //task4
        {
            var result = from student in students
                         where (student.Age >= 18 && student.Age <= 24)
                         select student;
            return result;
        }

        public static IEnumerable<T> OrderStudentLINQ<T>(this IEnumerable<T> students) where T : Student //task5
        {
            var result = from student in students
                         orderby student.FirstName descending, student.LastName descending
                         select student;
            return result;
        }

        public static IEnumerable<T> OrderStudentLambda<T>(this IEnumerable<T> students) where T : Student //task5
        {
            var result = students
                        .OrderByDescending(st => st.FirstName)
                        .ThenByDescending(st => st.LastName);
            return result;
        }

        public static IEnumerable<T> StudentGroups<T>(this IEnumerable<T> students) where T : Student //task9
        {
            var result = from student in students
                         where student.GroupNumber == 2
                         orderby student.FirstName
                         select student;

            return result;
        }

        public static IEnumerable<T> StudentGroupsSecond<T>(this IEnumerable<T> students) where T : Student  //task10
        {
            var result = students
                        .Where(st => st.GroupNumber == 2)
                        .OrderBy(st => st.FirstName);
            return result;
        }

        public static IEnumerable<T> ExtractStudentsByMail<T>(this IEnumerable<T> students) where T : Student  //task11
        {
            var result = from student in students
                         where student.Email.Contains("@abv.bg")
                         select student;
            return result;
        }

        public static IEnumerable<T> ExtractByPhone<T>(this IEnumerable<T> students) where T : Student //task12
        {
            var result = from student in students
                         where student.TelNumber.Contains("02")
                         select student;
            return result;
        }

        public static IEnumerable<T> ExtractStudentsByMark<T>(this IEnumerable<T> students) where T : Student //task 13 from the current list not from anonymous class
        {
            var result = from student in students
                         where student.Marks.Contains(6)
                         select student;
            return result;
        }

        public static IEnumerable<T> ExtractStudentsByMarkWithTwo<T>(this IEnumerable<T> students, int count) where T : Student //task 14 extracting student with two mark's
        {

            var result = students.Where(st => st.Marks.Count == count);
            return result;
        }

        public static string[] StudentsIn2006<T>(this IEnumerable<T> students) where T : Student //task15
        {
            var result = students.Where(st => st.FacultyNumber.Substring(4, 2) == "06")
                                 .Select(st => string.Join(" ", st.Marks))
                                 .ToArray();
            return result;
        }

        public static IEnumerable<T> GroupByGroupNumber<T>(this IEnumerable<T> students) where T : Student //task18
        {
            var result = (from student in students
                          orderby student.GroupNumber                         
                          select student).ToList();

            return result;
        }

        public static IEnumerable<T> GroupedByGroupNumberLambda<T>(this IEnumerable<T> students) where T : Student //task19
        {
            return students
                .OrderBy(st => st.GroupNumber)
                .ToList();
        }


    }
}
