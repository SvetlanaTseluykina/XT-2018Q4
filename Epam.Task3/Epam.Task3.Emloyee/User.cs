using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.User
{
   public class User
    {
        private string surname;
        private string name;
        private string patronymic;
        private System.DateTime dateOfBirth;
        private int age;

        public User(string surname, string name, string patronymic, int year, int month, int day, int age)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.dateOfBirth = new DateTime(year, month, day);
            this.age = age;
        }

        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                if (value != string.Empty)
                {
                    this.surname = value;
                }
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value != string.Empty)
                {
                    this.name = value;
                }
            }
        }

        public string GetPatronimyc
            => this.patronymic;

        public System.DateTime GetDateOfBirth
            => this.dateOfBirth.Date;

        public int GetAge
            => this.age;
    }
}
