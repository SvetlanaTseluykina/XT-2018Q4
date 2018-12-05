using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Employee
{
    public class Program
    {
        public static int MaxDay(int month)
        {
            if (month == 2)
            {
                return 28;
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Print surname: ");
            string surname = Console.ReadLine();
            while (surname.Trim() == string.Empty)
            {
                Console.WriteLine("You didn't write a surname, try again");
                Console.Write("Print surname: ");
                surname = Console.ReadLine();
            }

            Console.Write("Print name: ");
            string name = Console.ReadLine();
            while (name.Trim() == string.Empty)
            {
                Console.WriteLine("You didn't write a name, try again");
                Console.Write("Print name: ");
                name = Console.ReadLine();
            }

            Console.Write("Print patronymic: ");
            string patronymic = Console.ReadLine();
            while (patronymic.Trim() == string.Empty)
            {
                Console.WriteLine("You didn't write a patronymic, try again");
                Console.Write("Print patronymic: ");
                patronymic = Console.ReadLine();
            }

            int curYear = DateTime.Now.Year;
            Console.Write("Print year (>= {0} && <= {1}): ", curYear - 150, curYear - 18);
            int year;
            bool check = int.TryParse(Console.ReadLine(), out year);
            while (!check || year <= 0 || year > curYear || curYear - year > 150 || curYear - year < 18)
            {
                Console.WriteLine("Wrong year, try again");
                Console.Write("Print year (>= {0} && <= {1}): ", curYear - 150, curYear - 18);
                check = int.TryParse(Console.ReadLine(), out year);
            }

            Console.Write("Print month (> 0 && <= 12): ");
            int month;
            check = int.TryParse(Console.ReadLine(), out month);
            int curMonth = DateTime.Now.Month;
            bool correctMonth = true;
            if (year == curYear)
            {
                if (month <= curMonth)
                {
                    correctMonth = true;
                }
                else
                {
                    correctMonth = false;
                }
            }

            while (!check || month <= 0 || month > 12 || !correctMonth)
            {
                Console.WriteLine("Wrong month, try again");
                Console.Write("Print month (> 0 && <= 12): ");
                check = int.TryParse(Console.ReadLine(), out month);
                if (year == curYear)
                {
                    if (month <= curMonth)
                    {
                        correctMonth = true;
                    }
                    else
                    {
                        correctMonth = false;
                    }
                }
            }

            Console.Write("Print day (> 0 && <= {0}): ", MaxDay(month));
            int day;
            check = int.TryParse(Console.ReadLine(), out day);
            int curDay = DateTime.Now.Day;
            bool correctDay = true;
            if (year == curYear && month == curMonth)
            {
                if (day <= curDay)
                {
                    correctDay = true;
                }
                else
                {
                    correctDay = false;
                }
            }

            while (!check || day <= 0 || day > MaxDay(month) || !correctDay)
            {
                Console.WriteLine("Wrong day, try again");
                Console.Write("Print day (> 0 && <= {0}): ", MaxDay(month));
                check = int.TryParse(Console.ReadLine(), out day);
                if (year == curYear && month == curMonth)
                {
                    if (day <= curDay)
                    {
                        correctDay = true;
                    }
                    else
                    {
                        correctDay = false;
                    }
                }
            }

            int age = curYear - year;
            if (curMonth < month || (curMonth == month && curDay < day))
            {
                age--;
            }

            Console.Write("Print work experience: ");
            int workExperience;
            check = int.TryParse(Console.ReadLine(), out workExperience);
            while (!check || workExperience < 0)
            {
                Console.WriteLine("Wrong work experience, try again");
                Console.Write("Print work experience: ");
                check = int.TryParse(Console.ReadLine(), out workExperience);
            }

            Console.Write("Print post: ");
            string post = Console.ReadLine();
            while (post.Trim() == string.Empty)
            {
                Console.WriteLine("Wrong post, try again");
                Console.WriteLine("Print post: ");
                post = Console.ReadLine();
            }

            Employee employee = new Employee(surname, name, patronymic, year, month, day, workExperience, post);
            employee.Age = age;
            Console.WriteLine("Employee {0} {1} {2}, date of birth: {3}, age: {4}, work experience: {5}, post: {6} is created", employee.Surname, employee.Name, employee.GetPatronimyc, employee.GetDateOfBirth.ToShortDateString(), employee.Age, employee.WorkExperience, employee.Post);
            Console.WriteLine("You can change employee's surname, employee's name, employee's work experience or employee's post if you want to:");
            Console.WriteLine("surname - changes surname, name - changes name, work experience - changes work experience, post - changes post, any other input - changes nothing");
            string chosen = Console.ReadLine();
            switch (chosen)
            {
                case "surname":
                    {
                        Console.Write("Print surname: ");
                        surname = Console.ReadLine();
                        while (surname == string.Empty || surname == " ")
                        {
                            Console.WriteLine("You didn't write a surname, try again");
                            Console.Write("Print surname: ");
                            surname = Console.ReadLine();
                        }

                        employee.Surname = surname;
                        Console.WriteLine("Now the employee's surname is {0}", employee.Surname);
                        break;
                    }

                case "name":
                    {
                        Console.Write("Print name: ");
                        name = Console.ReadLine();
                        while (name == string.Empty || name == " ")
                        {
                            Console.WriteLine("You didn't write a name, try again");
                            Console.Write("Print name: ");
                            name = Console.ReadLine();
                        }

                        employee.Name = name;
                        Console.WriteLine("Now the employee's name is {0}", employee.Name);
                        break;
                    }

                case "work experience":
                    {
                        Console.Write("Print work experience: ");
                        check = int.TryParse(Console.ReadLine(), out workExperience);
                        while (!check || workExperience < 0 || workExperience < employee.WorkExperience)
                        {
                            Console.WriteLine("wrong work experience, try again");
                            Console.Write("Print work experience: ");
                            check = int.TryParse(Console.ReadLine(), out workExperience);
                        }

                        employee.WorkExperience = workExperience;
                        Console.WriteLine("Now the employee's workExperience is {0}", employee.WorkExperience);
                        break;
                    }

                case "post":
                    {
                        Console.WriteLine("Print post");
                        post = Console.ReadLine();
                        while (post == string.Empty || post == " ")
                        {
                            Console.WriteLine("Wrong post, try again");
                            Console.WriteLine("Print post");
                            post = Console.ReadLine();
                        }

                        employee.Post = post;
                        Console.WriteLine("Now the employee's post is {0}", employee.Post);
                        break;
                    }
                    
                default:
                    {
                        Console.WriteLine("You didn't change anything");
                        break;
                    }
            }
        }
    }
}
