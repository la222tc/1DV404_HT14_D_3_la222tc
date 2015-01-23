using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class test
    {
        public static void testForComparingUserinput()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Kollar så att användarnamnet och lösenordet matchar varandra");
            Console.WriteLine();
            Console.ResetColor();

            // Test 1
            try
            {
                Console.WriteLine("! Test 1 !");
                Console.WriteLine();
                var user1 = new Users("tjuue123", "hejhopp321");
                var login1 = new Login("tjuue123", "hejhopp321");
                login1.loginValidator(user1);
            }
            catch (Exception)
            {

                throw new ArgumentException("Något gick fel med testet!");
            }


            // Test 2
            try
            {
                Console.WriteLine("! Test 2 !");
                Console.WriteLine();
                var user1 = new Users("tjuue123", "hejhopp321");
                var login1 = new Login("tjuue321", "hejhopp321");
                login1.loginValidator(user1);
            }
            catch (Exception)
            {

                throw new ArgumentException("Något gick fel med testet!");

            }


            // Test 3
            try
            {
                Console.WriteLine("! Test 3 !");
                Console.WriteLine();
                var user1 = new Users("tjuue123", "hejhopp321");
                var login1 = new Login("tjuue123", "hejhopp123");
                login1.loginValidator(user1);
            }
            catch (Exception)
            {

                throw new ArgumentException("Något gick fel med testet!");
            }


            // Test 4
            try
            {
                Console.WriteLine("! Test 4 !");
                Console.WriteLine();
                var user1 = new Users("tjuue123", "hejhopp321");
                var login1 = new Login("tjuue321", "hejhopp123");
                login1.loginValidator(user1);
            }
            catch (Exception)
            {

                throw new ArgumentException("Något gick fel med testet!");
            }
        }

        public static void testForUserinputFormat()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Test för formatet av användarnamn och lösenord");
            Console.WriteLine();
            Console.ResetColor();

            var user = new Users();
            // Test 1
            try
            {

                Console.WriteLine("! Test 1 !");
                Console.WriteLine();
                user.Username = "tjuue123";
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Rätt format!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }


            // Test 2
            try
            {
                Console.WriteLine("! Test 2 !");
                Console.WriteLine();
                user.Username = "tjuue123öäå>>";
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }


            // Test 3
            try
            {
                Console.WriteLine("! Test 3 !");
                Console.WriteLine();
                user.Password = "hejhopp321";
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Rätt format!");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }


            // Test 4
            try
            {
                Console.WriteLine("! Test 4 !");
                Console.WriteLine();
                user.Password = "hejhopp321öäå>>";
            }
            catch (Exception e)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("---------------------");
            }
        }
    }
}
