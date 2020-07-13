using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            double qualityScore = Gpa * NumberOfCredits;
            double newScore = grade * courseCredits;
            qualityScore = qualityScore + newScore;
            NumberOfCredits = NumberOfCredits + courseCredits;
            Gpa = qualityScore / NumberOfCredits;

        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            // Determine the grade level of the student based on NumberOfCredits
            if (credits <= 29)
            {
                return "Freshman";
            }
            else if (credits <= 59 && credits >= 30)
            {
                return "Sophomore";

            }
            else if (credits >= 60 && credits <= 89)
            {
                return "Junior";
            }

            else if (credits >= 90)
            {
                return "Senior";
            }
            return "grade level tbd";
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override bool Equals(object toBeCompared)
        {
            if (toBeCompared == this)
            {
                return true;
            }

            if (toBeCompared == null)
            {
                return false;
            }

            if (toBeCompared.GetType() != this.GetType())
            {
                return false;
            }

            Student s = toBeCompared as Student;
            return s.StudentId == StudentId;
        }
    }
}
