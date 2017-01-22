using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//pridano
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Consolev2;
using Consolev2.Models;

namespace LANux_CMDux
{
    public class LogIn
    {

        private static Repository.UserRepository _userRepository = new Repository.UserRepository();
        private static MyContext _context = new MyContext();
        private static HttpClient client = new HttpClient();
        private static bool LogInStatus = false;
        //private bool success = false;
        public LogIn()
        {
            client.BaseAddress = new Uri("http://localhost:60284/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static void VyKresliLogIn()
        {
            Console.Clear();

            //pripsano
            User u = new User();
            Console.WriteLine("");
            Console.WriteLine("\n                                     ██╗    ██╗  ██╗ █████╗     ██████╗ ██████╗ ██╗     " +
                              "\n                                     ██║    ██║  ██║██╔══██╗    ██╔══██╗██╔══██╗██║     " +
                              "\n                                     ██║    ███████║╚█████╔╝    ██████╔╝██████╔╝██║     " +
                              "\n                                     ██║    ██╔══██║██╔══██╗    ██╔═══╝ ██╔═══╝ ██║     " +
                              "\n                                     ██║    ██║  ██║╚█████╔╝    ██║     ██║     ███████╗" +
                              "\n                                     ╚═╝    ╚═╝  ╚═╝ ╚════╝     ╚═╝     ╚═╝     ╚══════╝ \n \n");

            if (LogInStatus)
            {
                Console.WriteLine("Username: " + u.Username);
                Console.WriteLine("Password: " + u.Password);
                VyKresliLogIn();
            }
            else
            {
                Console.WriteLine("Please insert username...");
                u.Username = Console.ReadLine();
                Console.WriteLine("Please use your password...");
                u.Password = Console.ReadLine();


                HttpResponseMessage response = client.PostAsJsonAsync("api/Login", u).Result;
                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Try again");
                    Console.ReadLine();
                    VyKresliLogIn();
                }
                else
                {
                    LogInStatus = true;
                    Console.WriteLine("gg");
                    u.Password = Console.ReadLine();
                    VyKresliLogIn();
                }
            }
        }

        public string CreateMD5(string input)
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
