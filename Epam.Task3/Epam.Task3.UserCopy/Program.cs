using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.UserCopy
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
            Console.Write("Print year (>= {0} && <= {1}): ", curYear - 150, curYear);
            int year;
            bool check = int.TryParse(Console.ReadLine(), out year);
            while (!check || year <= 0 || year > curYear || curYear - year > 150)
            {
                Console.WriteLine("Wrong year, try again");
                Console.Write("Print year (>= {0} && <= {1}): ", curYear - 150, curYear);
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

            User user = new User(surname, name, patronymic, year, month, day);
            user.Age = age;
            Console.WriteLine("User {0} {1} {2}, date of birth: {3}, Age: {4} is created", user.Surname, user.Name, user.GetPatronimyc, user.GetDateOfBirth.ToShortDateString(), user.Age);
            Console.WriteLine("You can change user's surname or user's name if you want to:");
            Console.WriteLine("surname - change surname, name - change name, any other input - changes nothing");
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

                        user.Surname = surname;
                        Console.WriteLine("Now the user's surname is {0}", user.Surname);
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

                        user.Name = name;
                        Console.WriteLine("Now the user's name is {0}", user.Name);
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
