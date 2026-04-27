using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    class Group
    {
        public string GroupName {get; set;}
        public string FacultyName {get; set;}
        public int Year_fStudy {get; set;}
        public List<Student> Students {get; set;}

        public Group(string groupName, string facultyName, int year_Study)
        {
            GroupName = groupName;
            FacultyName = facultyName;
            Year_fStudy = year_Study;
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public override string ToString()
        {
            return $"Группа: {GroupName}, Факультет: {FacultyName}, Курс: {Year_fStudy}, Кол-во студентов: {Students.Count}";
        }

        public void PrintAllStudents()
        {
            Console.WriteLine($"\n Студенты группы {GroupName}");
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
