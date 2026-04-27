using System;
using System.Collections.Generic;

namespace Bd_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty Faculty1 = new Faculty("Фит",1952);
            Faculty Faculty2 = new Faculty("Физ",1933);

            Group groupCS101 = new Group("101", Faculty1.FacultyName, 1);
            Group groupCS102 = new Group("103", Faculty1.FacultyName, 1);

            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student(
                    $"Студентус{i} Фамилия{i}", 18 + i % 3, $"student{i}@gmail.ru", $"77",
                    $"НСК, ул. Кропоткина, д.{i}", $"ST{i:D3}", "101", Faculty1.FacultyName, 3.5 + (i % 5) * 0.3
                );
                groupCS101.AddStudent(student);
            }

            for (int i = 1; i <= 10; i++)
            {
                Student student = new Student(
                    $"Студент{(char)(64 + i)} Екатерина", 19 + i % 2, $"p{i}@mail.ru", $"464646",
                    $"Барнаул, ул Архипова д.{i + 10}", $"PHY{i:D3}", "102", Faculty1.FacultyName, 4.0 + (i % 4) * 0.25
                );
                groupCS102.AddStudent(student);
            }

            Faculty1.AddGroup(groupCS101);
            Faculty1.AddGroup(groupCS102);

            Lector teacher1 = new Lector(
                "Зырянова Алина Андреевна", 42, "e.zirianova@gmail.ru", "22", "НСК, ул. Свега, д.10",
                "01", "Профессор"
            );

            Lector teacher2 = new Lector(
                "Курилина Анжелика Максимовна", 52, "d.kurilkina@gmail.ru", "322", "Барнаул, ул. Болотино, д.3",
                "02", "Лектор"
            );
            Console.WriteLine(Faculty1);
            Console.WriteLine(Faculty2);

            Console.WriteLine(teacher1);
            Console.WriteLine(teacher2);
            groupCS101.PrintAllStudents();
            groupCS102.PrintAllStudents();
        }
    }
}