using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3task1
{
    class Human
    {
        protected string name;
        protected string surname;
        protected int age;
        protected string nationality;
        protected int playerid;
        protected string condition;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {

            get { return age; }
            set
            { age = value; }

        }
        public string Nationality
        {
            get { return nationality; }
            set { nationality = value; }
        }
        public int Playerid
        {
            get { return playerid; }
            set { playerid = value; }
        }
        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }
        public static string LineCheck()
        {
            string data;
            do
            {
                int correctness = 0;
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                for (int i = 0; i < data.Length; i++)
                {
                    if (!char.IsLetter(data[i]))
                    {
                        Console.Write("Use only characters \n");
                        correctness = 1;
                        break;
                    }
                }
                if (correctness != 0) continue;
                else break;
            } while (true);
            return data;

        }
        public static string TeamNicknameLineCheck()
        {
            string data;
            do
            {
                data = Console.ReadLine();
                if (data.Length == 0)
                {
                    Console.Write("Empty line detected\n");
                    continue;
                }
                else break;
            } while (true);

            return data;
        }
        public static int Agecheck()
        {
            string age;
            int ageint;
            while (true)
            {
                age = Console.ReadLine();
                if (!int.TryParse(age, out ageint))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToInt32(age) < 16)
                {
                    Console.WriteLine("He is too young to be a pro player");
                }
                else if (Convert.ToInt32(age) > 40)
                {
                    Console.WriteLine("Nah he is too old to be a pro player now");
                }
                else break;
            }
            return ageint;
        }
        public static int IdCheck()
        {
            string playerid;
            int completeid;
            while (true)
            {
                playerid = Console.ReadLine();
                if (!int.TryParse(playerid, out completeid))
                {
                    Console.Write("Try again\n ");

                }
                else break;
            }
            return completeid;
        }
        public void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid);
        }
        public void NewAge()
        {
            int age_new;
            Console.WriteLine("Enter new player's age:");
            string age_new2;
            while (true)
            {
                age_new2 = Console.ReadLine();
                if (!int.TryParse(age_new2, out age_new))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToInt32(age) < 16)
                {
                    Console.WriteLine("He is too young to be a pro player");
                }
                else if (Convert.ToInt32(age) > 40)
                {
                    Console.WriteLine("Nah he is too old to be a pro player now");
                }
                else break;
            }
            age = age_new;
        }
        public void NewId()
        {
            int new_id;
            Console.WriteLine("Enter new player's id:");
            string id_new;
            while (true)
            {
                id_new = Console.ReadLine();
                if (!int.TryParse(id_new, out new_id))
                {
                    Console.Write("Try again\n ");

                }
                else break;

            }
            playerid = new_id;
        }
        public Human()
        {
            Console.WriteLine("Name of the player");
            Name = Human.LineCheck();
            Console.WriteLine("Surname of the player:");
            Surname = Human.LineCheck();
            Console.WriteLine("Age is");
            Age = Human.Agecheck();
            Console.WriteLine("Nationality is");
            Nationality = LineCheck();
            Console.WriteLine("His Id is");
            Playerid = IdCheck();
        }
        public void Kill()
        {
            condition = " (dead)";
        }
        class Program
        {
            static void Main(string[] args)
            {
                Human first = new Human();
                bool close = false;
                char task;
                Console.Clear();
                while (close == false)
                {

                    Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change id \n 3 - change age\n 4 - kill \n 5 - close");
                    task = Console.ReadKey().KeyChar;
                    switch (task)
                    {
                        case '1':
                            first.ShowInfo();
                            break;
                        case '2':
                            Console.Clear();
                            first.NewId();
                            break;
                        case '3':
                            Console.Clear();
                            first.NewAge();
                            break;
                        case '4':
                            Console.Clear();
                            first.Kill();
                            Console.WriteLine("Now you are a killer");
                            break;
                        case '5':
                            close = true;
                            break;
                        default:
                            Console.WriteLine("Excellent choice");
                            break;
                    }
                }
            }
        }
    }
}

