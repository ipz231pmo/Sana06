using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryUser : People
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Paid { get; set; }
        public LibraryUser(string firstName, string lastName, int day, int month, int year, int id, string date, int paid) : base(firstName, lastName, day, month, year)
        {
            Id = id;
            Date = date;
            Paid = paid;
        }
        public override string ShowInfo()
        {
            return new string(
                $"Library User\n" +
                $"\tFirst Name: {FirstName}\n" +
                $"\tLast Name: {LastName}\n" +
                $"\tBirthday: {Birthday}\n" +
                $"\tID: {Id}\n" +
                $"\tRegister date: {Date}\n" +
                $"\tPaid: {Paid}\n");
        }
    }
}
