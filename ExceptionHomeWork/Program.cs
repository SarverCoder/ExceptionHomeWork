namespace ExceptionHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserProfile profile = new UserProfile();

            Console.Write("Username: ");
            profile.Username = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Password: ");
            profile.Password = Console.ReadLine();

            try
            {
                ValidateUser(profile);
                Console.Clear();
                Console.WriteLine("Welcome to system...");
            }
            catch (InvalidUserCredentialsException e)
            {
                Logger.LogError(e.Message, InvalidUserCredentialsException.Code);
            }
            finally
            {
                Console.WriteLine("Session finished");
            }
            
        }

        static void ValidateUser(UserProfile user)
        {
            if (!user.Equals("admin") && !user.Password.Equals("password"))
            {
                throw new InvalidUserCredentialsException();
            }

        }

    }

    class UserProfile
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }

}
