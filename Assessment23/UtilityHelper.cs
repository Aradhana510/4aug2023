// UtilityHelper.cs
using System;

namespace MySharedLibrary
{
    public class UtilityHelper
    {
        public bool ValidateData(string data)
        {
            return !string.IsNullOrEmpty(data);
        }

        public void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {message}");
        }
    }
}
