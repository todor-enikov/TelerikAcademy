using StudentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Data
{
    public class StudentSystemDbContext : DbContext
    {
        public StudentSystemDbContext()
            : base("StudentSystemDatabase")
        {

        }

        public virtual IDbSet<Course> Course { get; set; }

        public virtual IDbSet<Student> Student { get; set; }

        public virtual IDbSet<Homework> Homework { get; set; }

        public virtual IDbSet<Material> Material { get; set; }
    }
}
