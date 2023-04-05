using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class SimpleLoginApp
    {
       private string[] usernames;
       private string[] passwords;

       public SimpleLoginApp(string[] username, string[] password) 
       {
            this.usernames = username; 
            this.passwords = password;
       }
       
       public void PromptUser()
       {
            Console.WriteLine("==========Welcome To My App==========");

            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            for (int i = 0; i < usernames.Length; i++)
            {
                if (username == usernames[i])
                {
                    for (int j = 0; j < passwords.Length; j++)
                    {
                        if (password == passwords[j])
                        {
                            if (i == j)
                            {
                                Console.WriteLine("Login Successful!");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Login Denied!");
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
