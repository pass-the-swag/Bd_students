using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    class Student : Guy
    {
        public string StudentId {get; set;}
        public string GroupName {get; set;}
        public string University {get; set;}
        public string FacultyName {get; set;}
        public double AverageGrade {get; set;}

        public Student(string fullName, int age, string email, string phoneNumber, string address,string studentId, string groupName, string facultyName, double averageGrade, string university)
            : base(fullName, age, email, phoneNumber, address)
        {
            StudentId = studentId;
            GroupName = groupName;
            FacultyName = facultyName;
            AverageGrade = averageGrade;
            University = university;
        }

        public override string ToString()
        {
            return $"(СТУДЕНТ) {base.ToString()}, ВУЗ: {University} ID: {StudentId}, Группа: {GroupName}, Факультет: {FacultyName}, Средний балл: {AverageGrade:F2}";
        }
    }
}
