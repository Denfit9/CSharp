using System;

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
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
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
        public  Human()
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
            Console.WriteLine("Player's nickname is");
            Nickname = TeamNicknameLineCheck();
        }
        public void Kill()
        {
            condition = " (dead)";

        }
        public virtual void Career()
        {
            Console.WriteLine("");
        }
        
    }
    class Cser : Human
    {
        protected string role;
        protected double kd;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public double KD
        {
            get { return kd; }
            set { kd = value; }
        }
        public enum TeamRole
        {
            rifler=1,
            awper,
            captain,
            support
        }
        public static double PlayerKD()
        {
            
            string kd;
            double fullkd;
            while (true)
            {
                Console.WriteLine("\nEnter his K/D score   (ex. 2,43)");
                kd = Console.ReadLine();
                if (!double.TryParse(kd, out fullkd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            return fullkd;
        }
    
        public static string RoleChoosing()
        {
            string plrole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            return plrole;
        }
        public void RoleChanger()
        {
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            string plrole = "";
            char index;
            bool choice = false;
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            role = plrole;
        }
        public void KillDeathChanger()
        {
            string kd2;
            double fullkd;
            while (true)
            {
                Console.WriteLine("Enter his new K/D score   (ex. 2,43)");
                kd2 = Console.ReadLine();
                if (!double.TryParse(kd2, out fullkd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd2) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            kd = fullkd;
        }
        public Cser()
        {
            role = RoleChoosing();
            kd = PlayerKD();
        }
        public void ShowInfoV2()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
            Console.WriteLine("His role is: " + role);
            Console.WriteLine("His K/D score is: " + kd);
        }
        public override void Career()
        {
            Console.WriteLine("So he is a cs:go pro-player.");
        }
    }
    class Doter : Human
    {
        protected string role;
        protected double kd;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public double KD
        {
            get { return kd; }
            set { kd = value; }
        }
        public enum TeamRole
        {
            tank = 1,
            killer,
            support
        }
        public static double PlayerKD()
        {
            string kd;
            double fullkd;
            while (true)
            {
                Console.WriteLine("\nEnter his K/D score   (ex. 2,43)");
                kd = Console.ReadLine();
                if (!double.TryParse(kd, out fullkd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            return fullkd;
        }
        public static string RoleChoosing()
        {
            string plrole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - tank \n2 - killer\n3 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.tank);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.killer);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - tank \n2 - killer\n3 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            return plrole;
        }
        public void KillDeathChanger()
        {
            string kd2;
            double fullkd;
            while (true)
            {
                Console.WriteLine("Enter his new K/D score   (ex. 2,43)");
                kd2 = Console.ReadLine();
                if (!double.TryParse(kd2, out fullkd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd2) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            kd = fullkd;
        }
        public void RoleChanger()
        {
            string plrole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - tank \n2 - killer\n3 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.tank);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.killer);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - tank \n2 - killer\n3 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            role = plrole;
        }
        public void ShowInfoV2()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
            Console.WriteLine("His role is: " + role);
            Console.WriteLine("His K/D score is: " + kd);
        }
        public Doter (){
            role = RoleChoosing();
            kd = PlayerKD();
        }
        public override void Career()
        {
            Console.WriteLine("So he is a dota2 pro-player.");
        }
    }
    class Valoranter : Human
    {
        protected string role;
        protected double kd;
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public double KD
        {
            get { return kd; }
            set { kd = value; }
        }
        public enum TeamRole
        {
            rifler = 1,
            awper,
            captain,
            support
        }
        public static double PlayerKD()
        {
            string kd;
            double fullkd;
            while (true)
            {
                Console.WriteLine("\nEnter his K/D score   (ex. 2,43)");
                kd = Console.ReadLine();
                if (!double.TryParse(kd, out fullkd))
                {
                    Console.Write("Try again\n ");

                }else if (Convert.ToDouble(kd) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            return fullkd;
        }

        public static string RoleChoosing()
        {
            string plrole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            return plrole;
        }
        public void RoleChanger()
        {
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            string plrole = "";
            char index;
            bool choice = false;
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        plrole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        plrole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        plrole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        plrole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            role = plrole;
        }
        public void KillDeathChanger()
        {
            string kd2;
            double fullkd;
            while (true)
            {
                Console.WriteLine("Enter his new K/D score   (ex. 2,43)");
                kd2 = Console.ReadLine();
                if (!double.TryParse(kd2, out fullkd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd2) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            kd = fullkd;
        }
        public Valoranter()
        {
            role = RoleChoosing();
            kd = PlayerKD();
        }
        public void ShowInfoV2()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
            Console.WriteLine("His role is: " + role);
            Console.WriteLine("His K/D score is: " + kd);
        }
        public override void Career()
        {
            Console.WriteLine("So he is a valorant pro-player.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            bool cybersportsman = true;
            char task;
            Console.Clear();
            if (cybersportsman == true)
            {
                Console.Clear();
                while (close == false)
                {
                    Console.Clear();
                    Console.WriteLine("Choose human's game \n a- cs:go \n b - dota2 \n c - valorant");
                    task = Console.ReadKey().KeyChar;

                    switch (task)
                    {
                        case 'a': // cs:go
                            Console.Clear();
                            Cser cser = new Cser();
                            Console.Clear();
                            cser.Career();
                            while (close == false)
                            {
                                Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change id \n 3 - change age\n 4 - change nickname\n 5 - Change his role in team\n 6 - change his K/D score \n 7 - kill \n 8 - close");
                                task = Console.ReadKey().KeyChar;
                                switch (task)
                                {
                                    case '1':
                                        Console.Clear();
                                        cser.ShowInfoV2();
                                        break;
                                    case '2':
                                        Console.Clear();
                                        cser.NewId();
                                        break;
                                    case '3':
                                        Console.Clear();
                                        cser.NewAge();
                                        break;
                                    case '4':
                                        Console.Clear();
                                        cser.NameChanger();
                                        break;
                                    case '5':
                                        Console.Clear();
                                        cser.RoleChanger();
                                        break;
                                    case '6':
                                        Console.Clear();
                                        cser.KillDeathChanger();
                                        break;
                                    case '7':
                                        Console.Clear();
                                        cser.Kill();
                                        Console.WriteLine("Now you are a killer");
                                        break;
                                    case '8':
                                        close = true;
                                        break;
                                    default:
                                        Console.WriteLine("Excellent choice");
                                        break;
                                }
                            }
                            break;
                        case 'b': // dota
                            Console.Clear();
                            Doter doter = new Doter();
                            Console.Clear();
                            doter.Career();
                            while (close == false)
                            {
                                Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change id \n 3 - change age\n 4 - change nickname\n 5 - Change his role in team\n 6 - change his K/D score \n 7 - kill \n 8 - close");
                                task = Console.ReadKey().KeyChar;
                                switch (task)
                                {
                                    case '1':
                                        Console.Clear();
                                        doter.ShowInfoV2();
                                        break;
                                    case '2':
                                        Console.Clear();
                                        doter.NewId();
                                        break;
                                    case '3':
                                        Console.Clear();
                                        doter.NewAge();
                                        break;
                                    case '4':
                                        Console.Clear();
                                        doter.NameChanger();
                                        break;
                                    case '5':
                                        Console.Clear();
                                        doter.RoleChanger();
                                        break;
                                    case '6':
                                        Console.Clear();
                                        doter.KillDeathChanger();
                                        break;
                                    case '7':
                                        Console.Clear();
                                        doter.Kill();
                                        Console.WriteLine("Now you are a killer");
                                        break;
                                    case '8':
                                        close = true;
                                        break;
                                    default:
                                        Console.WriteLine("Excellent choice");
                                        break;
                                }
                            }
                            break;
                        case 'c': //kalorant
                            Console.Clear();
                            Valoranter val = new Valoranter();
                            Console.Clear();
                            val.Career();
                            while (close == false)
                            {
                                Console.WriteLine("\nwhat to do? \n 1 - Show info \n 2 - change id \n 3 - change age\n 4 - change nickname\n 5 - Change his role in team\n 6 - Change his K/D score \n 7 - kill \n 8 - close");
                                task = Console.ReadKey().KeyChar;
                                switch (task)
                                {
                                    case '1':
                                        Console.Clear();
                                        val.ShowInfoV2();
                                        break;
                                    case '2':
                                        Console.Clear();
                                        val.NewId();
                                        break;
                                    case '3':
                                        Console.Clear();
                                        val.NewAge();
                                        break;
                                    case '4':
                                        Console.Clear();
                                        val.NameChanger();
                                        break;
                                    case '5':
                                        Console.Clear();
                                        val.RoleChanger();
                                        break;
                                    case '6':
                                        Console.Clear();
                                        val.KillDeathChanger();
                                        break;
                                    case '7':
                                        Console.Clear();
                                        val.Kill();
                                        Console.WriteLine("Now you are a killer");
                                        break;
                                    case '8':
                                        close = true;
                                        break;
                                    default:
                                        Console.WriteLine("Excellent choice");
                                        break;
                                }
                            }
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
