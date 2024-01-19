using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student : People
    {
        public int Course {get; set;}
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }
        public Student(string firstName, string lastName, int day, int month, int year, int course, string group, string faculty, string university) : 
            base(firstName, lastName, day, month, year)
        {
            Course = course;
            Group = group; 
            Faculty = faculty;
            University = university;
        }
        public override string ShowInfo()
        {
            return new string($"Student\n\tFirst Name: {FirstName}\n\tLast Name: {LastName}\n\tBirthday: {Birthday}\n\tCourse: {Course}\n\t" +
                $"Group: {Group}\n\tFaculty: {Faculty}\n\tUniversity: {University}\n");
        }
    }
}
