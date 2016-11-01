using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schoolclasses
{
    class SchoolClassesMain
    {
        static void Main()
        {
            Teacher petkova = new Teacher("Petkova");
            Teacher ivanov = new Teacher("Ivanov");
            Teacher martinov = new Teacher("Martinov");

            petkova.AddDiscipline(new Disciplines("Math", 3, 5));
            petkova.AddDiscipline(new Disciplines("Information", 2, 1));
            petkova.AddDiscipline(new Disciplines("English", 7, 9));

            ivanov.AddDiscipline(new Disciplines("Math", 3, 5));
            ivanov.AddDiscipline(new Disciplines("Information", 2, 1));
            ivanov.AddDiscipline(new Disciplines("English", 7, 9));

            martinov.AddDiscipline(new Disciplines("Math", 3, 5));
            martinov.AddDiscipline(new Disciplines("Information", 2, 1));
            martinov.AddDiscipline(new Disciplines("English", 7, 9));

            //Clas A
            ClassInSchool classA = new ClassInSchool("Klas A");

            //Student of class
            classA.AddStudent(new Student("Veselin", 5));
            classA.AddStudent(new Student("Vasil", 2));
            classA.AddStudent(new Student("Georgi", 1));
            classA.AddStudent(new Student("Martin", 3));
            classA.AddStudent(new Student("Iordan", 7));

            //Teacher of class
            classA.AddTeacher(petkova);
            classA.AddTeacher(ivanov);
            classA.AddTeacher(martinov);

            //Clas B
            ClassInSchool classB = new ClassInSchool("Klas B");

            //Student of class
            classB.AddStudent(new Student("Veselin", 5));
            classB.AddStudent(new Student("Vasil", 1));
            classB.AddStudent(new Student("Georgi", 3));
            classB.AddStudent(new Student("Martin", 7));
            classB.AddStudent(new Student("Iordan", 2));

            //Teacher of class
            classB.AddTeacher(petkova);
            classB.AddTeacher(ivanov);


            //Clas C
            ClassInSchool classC = new ClassInSchool("Klas C");

            //Student of class
            classC.AddStudent(new Student("Veselin", 5));
            classA.AddStudent(new Student("Vasil", 1));
            classC.AddStudent(new Student("Georgi", 3));
            classC.AddStudent(new Student("Martin", 7));
            classC.AddStudent(new Student("Iordan", 2));

            //Teacher of class
            classC.AddTeacher(ivanov);
            classC.AddTeacher(martinov);


            //School
            School school = new School("Vasil Levski");

            school.AddClass(classA);
            school.AddClass(classB);
            school.AddClass(classC);

            foreach (var item in school.SchoolClass)
            {
                Console.WriteLine("\n" + item.Identifier);
                Console.WriteLine(item.ToString());
            }
        }
    }
}
