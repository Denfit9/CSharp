using System;

namespace Lab6fixed
{
    class Human : IComparable<Human>, IAlive
    {
        public void Laugh()
        {
            Console.WriteLine("Ha-ha so funny *laughes*");
        }
        public void Joke()
        {
            Console.WriteLine("Helvetica and Times New Roman walk into a bar.\n“Get out of here!” shouts the bartender. “We don’t serve your type.”");
        }
        public void Punch()
        {
            Console.WriteLine("Ouch! Punched right in his face");
        }
        public void Living(int age)
        {
            int Year = 2021;
            int Born = 0;
            Born = Year - age;
            Console.WriteLine("He was born around " + Born);

        }
        public int CompareTo(Human p)
        {
            return this.Age.CompareTo(p.Age);
        }
        protected string name;
        protected string surname;
        public int age;
        protected string nationality;
        protected int playerid;
        protected string condition;
        protected string nickname;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
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

        public static int AgeCheck()
        {
            string age;
            int AgeInt;
            while (true)
            {
                age = Console.ReadLine();
                if (!int.TryParse(age, out AgeInt))
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
            return AgeInt;
        }
        public static int IdCheck()
        {
            string PlayerId;
            int CompleteId;
            while (true)
            {
                PlayerId = Console.ReadLine();
                if (!int.TryParse(PlayerId, out CompleteId))
                {
                    Console.Write("Try again\n ");

                }
                else break;
            }
            return CompleteId;
        }
        public void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
        }
        public void NewAge()
        {
            int AgeNew;
            Console.WriteLine("Enter new player's age:");
            string AgeNew2;
            while (true)
            {
                AgeNew2 = Console.ReadLine();
                if (!int.TryParse(AgeNew2, out AgeNew))
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
            age = AgeNew;
        }
        public void NewId()
        {
            int NewId;
            Console.WriteLine("Enter new player's id:");
            string Id;
            while (true)
            {
                Id = Console.ReadLine();
                if (!int.TryParse(Id, out NewId))
                {
                    Console.Write("Try again\n ");

                }
                else break;

            }
            playerid = NewId;
        }
        public void NameChanger()
        {
            Console.WriteLine("Enter new nickname");
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

            nickname = data;
        }
        public Human()
        {
        }
        public void Kill()
        {
            condition = " (dead)";

        }
        public virtual void Career()
        {
            Console.WriteLine("");
        }
        public virtual void Check()
        {
            Console.WriteLine("");
        }
    }

}
