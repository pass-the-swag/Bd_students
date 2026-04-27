using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    class Student : Guy
    {
        public string StudentId { get; set; }
        public string GroupName { get; set; }
        public string FacultyName { get; set; }
        public double AverageGrade { get; set; }

        public Student(string fullName, int age, string email, string phoneNumber, string address,string studentId, string groupName, string facultyName, double averageGrade)
            : base(fullName, age, email, phoneNumber, address)
        {
            StudentId = studentId;
            GroupName = groupName;
            FacultyName = facultyName;
            AverageGrade = averageGrade;
        }

        public override string ToString()
        {
            return $"(СТУДЕНТ) {base.ToString()}, ID: {StudentId}, Группа: {GroupName}, Факультет: {FacultyName}, Средний балл: {AverageGrade:F2}";
        }
    }
}
