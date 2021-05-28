using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6fixed
{
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
            rifler = 1,
            awper,
            captain,
            support
        }
        public static double PlayerKD()
        {

            string kd;
            double FullKd;
            while (true)
            {
                Console.WriteLine("\nEnter his K/D score   (ex. 2,43)");
                kd = Console.ReadLine();
                if (!double.TryParse(kd, out FullKd))
                {
                    Console.Write("Try again\n ");

                }
                else if (Convert.ToDouble(kd) >= 5)
                {
                    Console.WriteLine("That is just impossible");
                }
                else break;
            }
            return FullKd;
        }

        public static string RoleChoosing()
        {
            string PlRole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        PlRole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        PlRole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        PlRole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        PlRole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            return PlRole;
        }
        public void RoleChanger()
        {
            Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
            string PlRole = "";
            char index;
            bool choice = false;
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        PlRole = Convert.ToString(TeamRole.awper);
                        choice = true;
                        break;

                    case '2':
                        PlRole = Convert.ToString(TeamRole.rifler);
                        choice = true;
                        break;
                    case '3':
                        PlRole = Convert.ToString(TeamRole.captain);
                        choice = true;
                        break;
                    case '4':
                        PlRole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - awper \n2 - rifler\n3 - captain\n4 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            role = PlRole;
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
            Console.WriteLine("Name of the player");
            Name = Cser.LineCheck();
            Console.WriteLine("Surname of the player:");
            Surname = Cser.LineCheck();
            Console.WriteLine("Age is");
            Age = Cser.AgeCheck();
            Console.WriteLine("Nationality is");
            Nationality = LineCheck();
            Console.WriteLine("His Id is");
            Playerid = IdCheck();
            Console.WriteLine("Player's nickname is");
            Nickname = TeamNicknameLineCheck();
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
        public override void Check()
        {
            Console.WriteLine("cs:go profile creator is working correctly");
        }
    }
}
