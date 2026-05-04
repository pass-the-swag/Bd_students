using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    class University
    {
        public string Name {get; set;}
        public string City {get; set;}
        public List<Faculty> Faculties {get; set;}

        public University(string name, string city)
        {
            Name = name;
            City = city;
            Faculties = new List<Faculty>();
        }
        public void AddFaculty(Faculty faculty) => Faculties.Add(faculty);

        public void PrintFullInfo()
        {
            Console.WriteLine($"\nУНИВЕРСИТЕТ: {Name} ({City})");
            foreach (var faculty in Faculties)
            {
                Console.WriteLine($"\n*[[[[* {faculty}*]]]]*");
                foreach (var group in faculty.Groups)
                {
                    Console.WriteLine($"\n  {group}");
                    group.PrintAllStudents();
                }
            }
        }
    }
}
