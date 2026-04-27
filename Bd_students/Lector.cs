using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    class Lector : Guy
    {
        public string TeacherId { get; set; }
        public string Position { get; set; }

        public Lector(string fullName, int age, string email, string phoneNumber, string address,
                       string teacherId, string position)
            : base(fullName, age, email, phoneNumber, address)
        {
            TeacherId = teacherId;
            Position = position;
        }

        public override string ToString()
        {
            return $"(ПРЕПОДАВАТЕЛЬ) {base.ToString()}, ID: {TeacherId}, Должность: {Position}";
        }
    }
}
