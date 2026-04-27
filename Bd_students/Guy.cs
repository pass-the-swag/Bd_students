using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bd_students
{
    abstract class Guy

    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Guy(string fullName, int age, string email, string phoneNumber, string address)
        {
            FullName = fullName;
            Age = age;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"ФИО: {FullName}, Возраст: {Age}, Почта: {Email}, Телефон: {PhoneNumber}, Адрес: {Address}";
        }
    }
}
