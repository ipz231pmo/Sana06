using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Lector : People
    {
        public string Post {  get; set; }
        public string Department { get; set; }
        public string Univercity { get; set; }
        public Lector(string firstName, string lastName, int day, int month, int year, string post, string department, string univercity) : base(firstName, lastName, day, month, year)
        {
            Post = post;
            Department = department;
            Univercity = univercity;
        }
        public override string ShowInfo()
        {
            return new string(
                $"Lector\n\t" +
                $"First Name: {FirstName}\n\t" +
                $"Last Name: {LastName}\n\t" +
                $"Birthday: {Birthday}\n\t" +
                $"Post: {Post}\n\t" +
                $"Department: {Department}\n\t" +
                $"University: {Univercity}\n");
        }
    }
}
