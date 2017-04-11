using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_Web_Controls_and_HTML_Controls
{
    public partial class StudentAndCourses : System.Web.UI.Page
    {
        //private readonly List<Student> students;

        //public StudentAndCourses()
        //{
        //    this.students = new List<Student>();
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            //this.AllStudents.Controls.Add(new Literal() { Text = "<div>some markup</div>" });
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            //var student = new Student(this.FirstNameTextBox.Text, this.LastNameTextBox.Text, this.FacultyNumberTextBox.Text, this.universityDropDownList.Text, this.SpecialtyDropDownList.Text);
            //this.students.Add(student);
            this.FirstNameAfterRegister.Text = this.FirstNameTextBox.Text;
            this.LastNameAfterRegister.Text = this.LastNameTextBox.Text;
            this.FacultyAfterRegister.Text = this.FacultyNumberTextBox.Text;
            this.UniversityAfterRegister.Text = this.universityDropDownList.Text;
            this.SpecialtyAfterRegister.Text = this.SpecialtyDropDownList.Text;
            this.CoursesAfterRegister.Text = this.ListOfCoursesListBox.Text;

        }
    }

    //public class Student
    //{
    //    public Student(string firstName, string lastName, string facultyNumber, string university, string specialty)
    //    {
    //        this.FirstName = firstName;
    //        this.LastName = lastName;
    //        this.FacultyNumber = facultyNumber;
    //        this.University = university;
    //        this.Specialty = Specialty;
    //    }

    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public string FacultyNumber { get; set; }
    //    public string University { get; set; }
    //    public string Specialty { get; set; }
    //    public List<string> Courses { get; set; }
    //}
}