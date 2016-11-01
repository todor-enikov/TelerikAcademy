using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class StudentsAndWorkersMain
    {
        static void Main()
        {
            Console.WriteLine("Sort by grade: \n");

            List<double> grades = new List<double>();
            grades.Add(2);
            grades.Add(5);
            grades.Add(3);
            grades.Add(6);
            grades.Add(4);

            List<Student> students = new List<Student>();
            students.Add(new Student("Vesko", "Plamenov", grades));
            students.Add(new Student("Georgi", "Goshev", grades));
            students.Add(new Student("Mitko", "Krustev", grades));
            students.Add(new Student("Martin", "Martinov", grades));
            students.Add(new Student("Tidor", "Krustev", grades));
            students.Add(new Student("Stanislav", "Bojinov", grades));
            students.Add(new Student("Mitko", "Ivanov", grades));
            students.Add(new Student("Nikolai", "Krustev", grades));
            students.Add(new Student("Valio", "Todorov", grades));
            students.Add(new Student("Vasko", "Petkov", grades));

            var sortingStudentsByGrades = students.SortingByGrades();
            foreach (var student in sortingStudentsByGrades)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sort by money per hour: \n");

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Vesko", "Plamenov", 50, 7));
            workers.Add(new Worker("Georgi", "Goshev", 200, 7));
            workers.Add(new Worker("Mitko", "Krustev", 70, 7));
            workers.Add(new Worker("Martin", "Martinov", 230, 7));
            workers.Add(new Worker("Tidor", "Krustev", 130, 7));
            workers.Add(new Worker("Stanislav", "Bojinov", 250, 7));
            workers.Add(new Worker("Mitko", "Ivanov", 100, 7));
            workers.Add(new Worker("Nikolai", "Krustev", 300, 7));
            workers.Add(new Worker("Valio", "Todorov", 190, 7));
            workers.Add(new Worker("Vasko", "Petkov", 270, 7));

            var sortWorkers = workers.SortingByMoneyPerHour();

            foreach (var worker in sortWorkers)
            {
                Console.WriteLine(worker.ToString());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sort by first and last name: \n");
            List<Human> humans = new List<Human>();

            foreach (var student in students)
            {
                humans.Add(student);
            }

            foreach (var worker in workers)
            {
                humans.Add(worker);
            }

            var allHumans = humans.SortingAllHumans();

            foreach (var human in allHumans)
            {
                Console.WriteLine(human);
            }
            
        }
    }
}
