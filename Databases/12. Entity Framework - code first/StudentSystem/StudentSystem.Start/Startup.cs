using StudentSystem.Data;
using StudentSystem.Data.Migrations;
using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Start
{
    public class Startup
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());

            var db = new StudentSystemDbContext();
            db.Database.CreateIfNotExists();

            var firstStudent = new Student()
            {
                FirstName = "Pesho",
                LastName = "Ivanov",
                Number = 123423
            };

            var secondStudent = new Student()
            {
                FirstName = "Penka",
                LastName = "Draganova",
                Number = 32
            };

            db.Student.Add(firstStudent);
            db.Student.Add(secondStudent);

            var idCoures = db.Course
                             .Where(x => x.Name == "Math")
                             .FirstOrDefault();

            var newMaterial = new Material()
            {
                Name = "New Mater",
                CourseId = idCoures.Id
            };

            db.Material.Add(newMaterial);

            Console.WriteLine("Students added successfully!");
            db.SaveChanges();
        }
    }
}
