using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.
        public override string ToString()
        {
            return Topic + " with " + Instructor + " and " + enrolledStudents.Count + " enrolled students.";
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.
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

            Course c = toBeCompared as Course;
            return c.Topic == Topic;
        }
}
