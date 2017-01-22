using LANux_CMDux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Consolev2
{
    public class Program
    {
        //static LocalUser _user = new LocalUser();
        private static HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            int mod = 0;
            while (mod != -1)
            {
                if (mod == 0)
                    mod = MenuMod(); //Main menu
                else if (mod == 1)
                    mod = LogInMod(); //Log In
                else if (mod == 2)
                    mod = SignUpMod(); //Sign Up
                else if (mod == 3)
                    mod = CrossRoadMod(); //CrossRoad
                else if (mod == 4)
                    mod = JoinRoomMod();
                else if (mod == 5)
                    mod = CreateRoomMod();
                else if (mod == 6)
                    mod = FriendsMod();
                else if (mod == 7)
                    mod = SettingsMod();
                //else if (mod == 8)
                //    mod = Mod();

                //CROSSROAD
            }
        }

        /*--------------------------MENU MODS--------------------------*/
        // menu = mod 0
        static int MenuMod()
        {
            String[] Options = new string[] { "LOG IN    ", "SIGN UP   ", "EXIT      " };
            int Highlighted = 0;

            ConsoleKey key = ConsoleKey.F1;
            while (key != ConsoleKey.Escape)
            {
                VykresliMainMenu();
                VykresliOptionsMenu(Options, Highlighted);

                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow && Highlighted > 0)
                    Highlighted--;
                else if (key == ConsoleKey.DownArrow && Highlighted < Options.Length - 1)
                    Highlighted++;
                else if (key == ConsoleKey.Enter)
                {
                    return Highlighted + 1;
                }
            }
            return -1;
        }

        // LogIn = mod 1
        static int LogInMod()
        {
            String[] Options = new string[] {"CONTINUE      ", "EXIT      " };
            int Highlighted = 0;
            //LogIn l = new LogIn();

            ConsoleKey key = ConsoleKey.F1;
            while (key != ConsoleKey.Escape)
            {
                LogIn.VyKresliLogIn();
                VykresliOptionsMenu(Options, Highlighted);

                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow && Highlighted > 0)
                    Highlighted--;
                else if (key == ConsoleKey.DownArrow && Highlighted < Options.Length - 1)
                    Highlighted++;
                else if (key == ConsoleKey.Enter)
                {
                    if (Highlighted == 0)
                        return 3;
                    else
                        return -1;
                }
                    //return Highlighted + 1;
            }
            return 0;
        }

        // SignUp = mod 2
        static int SignUpMod()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");
            Console.WriteLine("jsi v SignUp");
            Console.ReadLine();
            return 0;
        }

        //CrossRoad = mod 3
        static int CrossRoadMod()
        {
            String[] Options = new string[] { "JOIN CHATROOM       ", "CREATE CHATROOM     ", "FRIENDS             ", "SETTINGS            ", "EXIT                " };
            int Highlighted = 0;

            ConsoleKey key = ConsoleKey.F1;
            while (key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");
                VykresliOptionsMenu(Options, Highlighted);

                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow && Highlighted > 0)
                    Highlighted--;
                else if (key == ConsoleKey.DownArrow && Highlighted < Options.Length - 1)
                    Highlighted++;
                else if (key == ConsoleKey.Enter)
                {
                    if (Highlighted == 0)
                        return 4;
                    if (Highlighted == 1)
                        return 5;
                    if (Highlighted == 2)
                        return 6;
                    if (Highlighted == 3)
                        return 7;
                    else
                        return -1;
                }
                //return Highlighted + 1;
            }
            return 0;
        }

        // JoinRoom = mod 4
        static int JoinRoomMod()
        {
            Console.Clear();
            Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");
            Console.WriteLine("Jsem v JoinRoom");
            Console.ReadLine();
            return 3;
        }

        // CreateRoom = mod 5
        static int CreateRoomMod()
        {
            Console.Clear();
            Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");
            Console.WriteLine("Jsem v CreateRoom");

            Console.ReadLine();
            return 3;
        }

        // Friends = mod 6
        static int FriendsMod()
        {
            Console.Clear();
            Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");
            Console.WriteLine("Jsem v Friends");

            Console.ReadLine();
            return 3;
        }

        // Settings = mod 7
        static int SettingsMod()
        {
            Console.Clear();
            Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");
            Console.WriteLine("Jsem v Settings");

            Console.ReadLine();
            return 3;
        }


        /*--------------------------VYKRESLI--------------------------*/
        static void VykresliOptionsMenu(string[] Options, int Highlighted)
        {
            int i = 0;
            foreach (string Item in Options)
            {
                if (i == Highlighted)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Gray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine(Item);
                i++;
            }
        }

        static void VykresliMainMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝");

            Console.WriteLine(@"                                                          ___---___  " + "\n" +
                              @"                                                       .--         --." + "\n" +
                              @"                                                     ./   ()      .-. \." + "\n" +
                              @"                                                    /   o    .   (   )  \" + "\n" +
                              @"                                                   / .            '-'    \" + "\n" +
                              @"                                                  | ()    .  O         .  |" + "\n" +
                              @"                                                 |          TEAM_D         |" + "\n" +
                              @"                                                 |    o           ()       |" + "\n" +
                              @"                                                 |       .--.          O   |" + "\n" +
                              @"                                                  | .   |    |            |" + "\n" +
                              @"                                                   \    `.__.'    o   .  /" + "\n" +
                              @"                                                    \                   /" + "\n" +
                              @"                                                     `\  o    ()      /'" + "\n" +
                              @"                                                       `--___   ___--'" + "\n" +
                              @"                                                             ---");
            Console.WriteLine("");
            Console.WriteLine("                                              UpDown_ARROWS   TAB   ESC   ENTER \n \n");
        }
        
        //static void VyKresliLogIn()
        //{
        //    Console.Clear();

        //    client.BaseAddress = new Uri("http://localhost:60284/");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    //pripsano
        //    //LocalUser _user = new LocalUser();
        //    Models.User u = new Models.User();



        //    Console.WriteLine("");
        //    Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
        //                      "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
        //                      "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
        //                      "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
        //                      "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
        //                      "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");

        //    //if (_user.Username != null || _user.Password != null)
        //    //{
        //    //    Console.WriteLine("Logged in!!" + "\n" + "Username: " + _user.Username + "\n" + "Password: " + _user.Password + "\n \n");
        //    //}


        //    //else //If verification == false
        //    //{
        //    //    Console.WriteLine("Please insert username...");
        //    //    _user.Username = Console.ReadLine();
        //    //    Console.WriteLine("Please use your password...");
        //    //    _user.Password = Console.ReadLine();
        //    //    VyKresliLogIn();
        //    //}
        //    if (u.Username == null || u.Password == null)
        //    {
        //        Console.WriteLine("Please insert username...");
        //        u.Username = Console.ReadLine();
        //        Console.WriteLine("Please use your password...");
        //        u.Password = Console.ReadLine();
        //    }

        //    HttpResponseMessage response = client.PostAsJsonAsync("api/Login", u).Result;
        //    if (!response.IsSuccessStatusCode)
        //    {
        //        Console.WriteLine("Try again");
        //    }
        //    else
        //    {
        //        Console.WriteLine("gg");
        //        VyKresliLogIn();
        //    }
        //}

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}

