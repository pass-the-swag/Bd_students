using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    class Faculty
    {
        public string Name {get; set;}
        public List<Group> Groups {get; set;}
        public List<Lector> Lectors {get; set;}

        public Faculty(string name)
        {
            Name = name;
            Groups = new List<Group>();
            Lectors = new List<Lector>();
        }

        public void AddGroup(Group group) => Groups.Add(group);
        public void AddLector(Lector lector) => Lectors.Add(lector);
        public override string ToString() => $"Факультет: {Name}, Групп: {Groups.Count}, Преподавателей: {Lectors.Count}";
    }
}