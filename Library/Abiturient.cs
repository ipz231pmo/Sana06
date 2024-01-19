using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Abiturient : People
    {
        public float ZNO {  get; set; }
        public float Atestat { get; set; }
        public string School { get; set; }

        public Abiturient (string firstName, string lastName, int day, int month, int year, float zNO, float atestat, string school) : base(firstName, lastName, day, month, year)
        {
            ZNO = zNO;
            Atestat = atestat;
            School = school;
        }
        public override string ShowInfo()
        {
            return new string($"Abiturient\n\tFirst Name: {FirstName}\n\tLast Name: {LastName}\n\tBirthday: {Birthday}\n\tZNO: {ZNO}\n\tAtestat: {Atestat}\n\tSchool: {School}\n");
        }
    }
}
