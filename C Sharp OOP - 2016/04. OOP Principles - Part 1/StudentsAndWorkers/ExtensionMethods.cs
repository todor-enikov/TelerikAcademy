using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<T> SortingByGrades<T>(this IEnumerable<T> students) where T : Student
        {
            var result = from student in students
                         orderby student.Grades
                         select student;
            return result;
        }

        public static IEnumerable<T> SortingByMoneyPerHour<T>(this IEnumerable<T> workers) where T : Worker
        {
            var result = from worker in workers
                         orderby worker.MoneyPerHour()
                         select worker;
            return result;
        }

        public static IEnumerable<T> SortingAllHumans<T>(this IEnumerable<T> humans) where T : Human
        {
            var result = from human in humans
                         orderby human.FirstName,human.LastName
                         select human;
            return result;
        }
    }
}
