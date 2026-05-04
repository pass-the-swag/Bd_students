using System;
using System.Collections.Generic;

namespace Bd_students
{
    class Program
    {
        static string[] firstNames = { "Алина", "Петр", "Владимир", "Екатерина", "Артем", "Александра", "Аристарх", "Денис" };
        static string[] lastNames = { "Зырянов(а)", "Никитин(а)", "Собержанин(а)", "Старков(а)", "Волков(а)", "Майдудуров(а)", "Попов(а)", "Бауэр" };
        static string[] nskStreets = { "Красный проспект", "ул. Ленина", "ул. Выборная", "ул. Кирова", "проспект Маркса", "ул. Бориса Богаткова", "ул. Ватутина", "ул. Пирогова" };
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            University myUni = new University("НГУ", "Новосибирск");
            Faculty fit = new Faculty("ИТ");
            myUni.AddFaculty(fit);

            Lector mainLector = new Lector(" Барецкий Станислав Валерьевич", 67, "boruech@gmail.com", "+79469703678", "пр. Маркса 20", "L777", "Профессор");
            fit.AddLector(mainLector);

            Group group1 = new Group("БО", fit.Name, 1);
            Group group2 = new Group("СПО", fit.Name, 1);

            fit.AddGroup(group1);
            fit.AddGroup(group2);
            group1.SetLector(mainLector);
            group2.SetLector(mainLector);
            FillGroup(group1, 5, "111", myUni.Name);
            FillGroup(group2, 5, "222", myUni.Name);
            myUni.PrintFullInfo();
        }
        static void FillGroup(Group group, int c, string rndom, string university)
        {
            for (int i = 1; i <= c; i++)
            {
                string randomName = firstNames[rnd.Next(firstNames.Length)];
                string randomLastName = lastNames[rnd.Next(lastNames.Length)];
                string fullName = $"{randomLastName} {randomName}";
                string randomStreet = nskStreets[rnd.Next(nskStreets.Length)];

                var student = new Student(
                    fullName,
                    rnd.Next(18, 23),
                    $"mail{i}_{rndom}@gmail.com",
                    $"+7900{rnd.Next(100, 999)}{i:D2}",
                    $"{randomStreet}, д.{rnd.Next(1, 150)}, кв.{i}",
                    $"ID-{rndom}-{i:D2}",
                    group.GroupName,
                    group.FacultyName,
                    rnd.NextDouble() * (5 - 3) + 3,
                    university
                );
                group.AddStudent(student);
            }
        }
    }
}