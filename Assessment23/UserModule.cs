// UserModule.cs
using MySharedLibrary;

namespace MainApp
{
    public class UserModule
    {
        private UtilityHelper _utilityHelper;

        public UserModule()
        {
            _utilityHelper = new UtilityHelper();
        }

        public void ManageUsers()
        {
            Console.WriteLine("User management functionality");

            // Use shared library methods
            string userInput = Console.ReadLine();
            if (_utilityHelper.ValidateData(userInput))
            {
                _utilityHelper.LogMessage("User data is valid");
            }
            else
            {
                _utilityHelper.LogMessage("User data is not valid");
            }
        }
    }
}
