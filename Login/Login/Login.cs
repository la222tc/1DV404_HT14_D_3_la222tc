using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Login
    {


        private string _username;
        private string _password;


        
        public void loginValidator(Users users)
        {
            

            // Kollar så att användarnamnet och lösenordet matchar varandra
            if (users.Username == _username && _password == users.Password)
        	{
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Lyckad inloggning!");
                Console.ResetColor();
                Console.WriteLine();
	        }

            else if (users.Username != _username && _password == users.Password)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Misslyckad inloggning! Fel Användarnamn!");
                Console.ResetColor();
                Console.WriteLine();
            }

            else if (_username == users.Username && users.Password != _password)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Misslyckad inloggning! Fel Lösenord!");
                Console.ResetColor();
                Console.WriteLine();
            }

            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Misslyckad inloggning! Användarnamn och Lösenorder matchar ej!");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        public Login(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}
