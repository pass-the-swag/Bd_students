using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    class Faculty
    {
        public string FacultyName { get; set; }
        public int Found { get; set; }
        public List<Group> Groups { get; set; }

        public Faculty(string facultyName, int foundationYear)
        {
            FacultyName = facultyName;
            Found = foundationYear;
            Groups = new List<Group>();
        }

        public void AddGroup(Group group)
        {
            Groups.Add(group);
        }

        public override string ToString()
        {
            return $"Факультет: {FacultyName}, Год оснвания: {Found}";
        }
    }

}
