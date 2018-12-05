using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    public class Employee : User
    {
        private int workExperience;
        private string post;

        public Employee(string surname, string name, string patronymic, int year, int month, int day, int workExperience, string post) : base(surname, name, patronymic, year, month, day)
        {
            this.workExperience = workExperience;
            this.post = post;
        }

        public int WorkExperience
        {
            get
            {
                return this.workExperience;
            }

            set
            {
                if (value >= 0)
                {
                    this.workExperience = value;
                }
            }
        }

        public string Post
        {
            get
            {
                return this.post;
            }

            set
            {
                if (value != string.Empty)
                {
                    this.post = value;
                }
            }
        }
    }
}
