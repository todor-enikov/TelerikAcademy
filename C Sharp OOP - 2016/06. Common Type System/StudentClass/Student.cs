using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public class Student  : ICloneable, IComparable<Student>//task1 
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private ulong socialSecurityNumber;
        private string permanentAddress;
        private ulong phoneNumber;
        private string email;
        private int course;
        private enumSpecialities speciality;
        private enumUniversities university;
        private enumFaculties faculty;

        public Student(string firstNameStudent, string middleNameStudent, string lastNameStudent, ulong socialSecutiryNumberStudent,
            string permanentAddressStudent, ulong phoneNumberStudent, string emailStudent, int courseStudent,
            enumSpecialities specialityStudent, enumUniversities universityStudent, enumFaculties facultyStudent)
        {
            this.FirstName = firstNameStudent;
            this.MiddleName = middleNameStudent;
            this.LastName = lastNameStudent;
            this.SocialSecurityNumber = socialSecutiryNumberStudent;
            this.PermanentAddress = permanentAddressStudent;
            this.PhoneNumber = phoneNumberStudent;
            this.Email = emailStudent;
            this.Course = courseStudent;
            this.Speciality = specialityStudent;
            this.University = universityStudent;
            this.Faculty = facultyStudent;
        }

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }

        public string MiddleName { get { return this.middleName; } set { this.middleName = value; } }

        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public ulong SocialSecurityNumber { get { return this.socialSecurityNumber; } set { this.socialSecurityNumber = value; } }

        public string PermanentAddress { get { return this.permanentAddress; } private set { this.permanentAddress = value; } }

        public ulong PhoneNumber { get { return this.phoneNumber; } set { this.phoneNumber = value; } }

        public string Email { get { return this.email; } set { this.email = value; } }

        public int Course { get { return this.course; } set { this.course = value; } }

        public enumSpecialities Speciality { get { return this.speciality; } set { this.speciality = value; } }

        public enumUniversities University { get { return this.university; } set { this.university = value; } }

        public enumFaculties Faculty { get { return this.faculty; } set { this.faculty = value; } }

        public override string ToString()
        {
            return string.Format("Information for student: {0} {1} {2}\nSocial security number: {3}   Permanent Address: {4}\nPhone: {5}   Email: {6}   Course: {7}\nUniversity: {8}   Faculty: {9}   Speciality: {10}\n\n"
                , this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.PermanentAddress, this.PhoneNumber, this.Email, this.Course, this.University, this.Faculty, this.Speciality);
        }

        public override bool Equals(object student)
        {
            var objectAsStudent = student as Student;
            if (objectAsStudent == null)
            {
                return false;
            }
            if (objectAsStudent.FirstName != this.FirstName)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }


        public object Clone() //task2
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SocialSecurityNumber, this.PermanentAddress, 
                this.PhoneNumber, this.Email, this.Course, this.Speciality, this.University, this.Faculty);
        }

        public int CompareTo(Student student) //task3
        {
            if (student.FirstName.CompareTo(this.FirstName)==0)
            {
                return student.SocialSecurityNumber.CompareTo(this.SocialSecurityNumber);
            }
            return student.FirstName.CompareTo(this.FirstName);
        }
    }
}
