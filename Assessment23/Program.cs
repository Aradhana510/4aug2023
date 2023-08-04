using System;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Application");

            UserModule userModule = new UserModule();
            userModule.ManageUsers();
        }
    }
}
