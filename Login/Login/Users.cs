using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Login
{
    class Users
    {
        private string theUsername;
        private string thePassword;

        //Egenskap som returnerar _username's värde och kollar ifall det är i rätt format
        public string Username
        {
            get { return theUsername; }

            set 
            {
                if (!UsernameInput(value))
                {
                    throw new ArgumentException("Fel Format!");
                }


                theUsername = value;
            }
        }

        //Egenskap som returnerar _password's värde och kollar ifall det är i rätt format
        public string Password
        {
            get { return thePassword; }

            set
            {
                if (!PasswordInput(value))
                {
                    throw new ArgumentException("Fel Format!");
                }

                thePassword = value;
            }
        }

        public Users(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Users()
        {

        }

        // Kollar så att användarnamnet är i ett speciellt format
        public bool UsernameInput (string username)
        {
            return Regex.IsMatch(username, "^[a-z0-9_-]{3,15}$");
        }


        // Kollar så att lösenordet är i ett speciellt format
        public bool PasswordInput(string password)
        {
            return Regex.IsMatch(password, "^[a-z0-9_-]{3,18}$");
        }
    }
}
