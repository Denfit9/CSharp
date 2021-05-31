using System;

namespace Lab8
{
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
            double FullKd;
            while (true)
            {
                try
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
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message + "\n");
                }
            }
            return FullKd;
        }
        public static string RoleChoosing()
        {
            string PlRole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - tank \n2 - killer\n3 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        PlRole = Convert.ToString(TeamRole.tank);
                        choice = true;
                        break;

                    case '2':
                        PlRole = Convert.ToString(TeamRole.killer);
                        choice = true;
                        break;
                    case '3':
                        PlRole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - tank \n2 - killer\n3 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            return PlRole;
        }
        public void KillDeathChanger()
        {
            string kd2;
            double FullKd;
            while (true)
            {
                try
                {
                    Console.WriteLine("\nEnter his K/D score   (ex. 2,43)");
                    kd2 = Console.ReadLine();
                    if (!double.TryParse(kd2, out FullKd))
                    {
                        Console.Write("Try again\n ");

                    }
                    else if (Convert.ToDouble(kd2) >= 5)
                    {
                        Console.WriteLine("That is just impossible");
                    }
                    else break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message + "\n");
                }
            }
            kd = FullKd;
        }
        public void RoleChanger()
        {
            string PlRole = "";
            char index;
            bool choice = false;
            Console.WriteLine("1 - tank \n2 - killer\n3 - support");
            index = Console.ReadKey().KeyChar;
            while (choice == false)
            {
                switch (index)
                {
                    case '1':
                        PlRole = Convert.ToString(TeamRole.tank);
                        choice = true;
                        break;

                    case '2':
                        PlRole = Convert.ToString(TeamRole.killer);
                        choice = true;
                        break;
                    case '3':
                        PlRole = Convert.ToString(TeamRole.support);
                        choice = true;
                        break;
                    default:
                        Console.WriteLine("1 - tank \n2 - killer\n3 - support");
                        index = Console.ReadKey().KeyChar;
                        break;
                }
            }
            role = PlRole;
        }
        string Bank, Pay, Donate, Fun;
        int bank, pay, donate, fun;
        public Doter()
        {
            Console.WriteLine("Name of the player");
            Name = Doter.LineCheck();
            Console.WriteLine("Surname of the player:");
            Surname = Doter.LineCheck();
            Console.WriteLine("Age is");
            Age = Doter.AgeCheck();
            Console.WriteLine("Nationality is");
            Nationality = LineCheck();
            Console.WriteLine("His Id is");
            Playerid = IdCheck();
            Console.WriteLine("Player's nickname is");
            Nickname = TeamNicknameLineCheck();
            role = RoleChoosing();
            kd = PlayerKD();
            Console.WriteLine("How much money does this player have?");
            Bank = Console.ReadLine();
            while (!int.TryParse(Bank, out bank))
            {
                Console.Write("Try again\n ");
                Bank = Console.ReadLine();
            }
            Console.WriteLine("How much money do you need to pay for some fun?");
            while (!int.TryParse(Pay, out pay))
            {
                Pay = Console.ReadLine();
            }
        }
        public void ShowInfoV2()
        {
            Console.Clear();
            Console.WriteLine("Name is: " + name + "\nSurname is: " + surname + "\nAge is: " + age + condition + "\nNationality is: " + nationality +
                "\nHis player id is: " + playerid + "\nHis in-game nickname is: " + nickname);
            Console.WriteLine("His role is: " + role);
            Console.WriteLine("His K/D score is: " + kd + "\n");
            Delegate pocket = new Delegate(Convert.ToInt32(bank));
            pocket.notify += delegate (string mess)
            {
                Console.WriteLine(mess);
            };
            pocket.Have(Convert.ToInt32(bank));
            Console.WriteLine("Now he has " + pocket.Payment + " $");
            pocket.Payed(Convert.ToInt32(pay));
            Console.WriteLine("Updated \nNow he has " + pocket.Payment + " $");
            if (donate > 0)
            {
                pocket.notify1 += mess => Console.WriteLine(mess);
                pocket.Added(Convert.ToInt32(donate));
                Console.WriteLine("Updated \nNow he has " + pocket.Payment + " $");
            }
            if (fun > 0)
            {
                pocket.notify1 += mess => Console.WriteLine(mess);
                pocket.Payed(Convert.ToInt32(fun));
                Console.WriteLine("Updated\nNow he has " + pocket.Payment + " $");
            }
        }
        public void Rich()
        {
            Console.Write("Choose how much do you want to give this player\n ");
            Donate = Console.ReadLine();
            while (!int.TryParse(Donate, out donate))
            {
                Console.Write("Try again\n ");
                Donate = Console.ReadLine();
            }

            Delegate pocket = new Delegate(Convert.ToInt32(bank - pay));
            pocket.notify1 += mess => Console.WriteLine(mess);
            pocket.Added(Convert.ToInt32(donate));
        }
        public void Poor()
        {
            Console.Write("How much money do you want to pay for some rest//fun\n ");
            Fun = Console.ReadLine();
            while (!int.TryParse(Fun, out fun))
            {
                Console.Write("Try again\n ");
                Fun = Console.ReadLine();
            }
            if (bank - pay < 0)
            {
                Delegate pocket = new Delegate(Convert.ToInt32(bank + donate));
                pocket.notify += mess => Console.WriteLine(mess);
                pocket.Payed(Convert.ToInt32(fun));
            }
            else
            {
                Delegate pocket = new Delegate(Convert.ToInt32(bank - pay + donate));
                pocket.notify += mess => Console.WriteLine(mess);
                pocket.Payed(Convert.ToInt32(fun));

            }
        }


        public override void Career()
        {
            Console.WriteLine("So he is a dota2 pro-player.");
        }
        public override void Check()
        {
            Console.WriteLine("Dota profile creator is working correctly");
        }
    }
}
