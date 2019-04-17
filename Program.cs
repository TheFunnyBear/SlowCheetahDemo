using System;
using System.Collections.Specialized;
using System.Configuration;

namespace SlowCheetahDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            NameValueCollection section = (NameValueCollection)ConfigurationManager.GetSection("appSettings");
            string id = section["userId"];
            string userName = section["userName"];
            string userPassword = section["userPassword"];
            
            Console.WriteLine("Loaded from configuration:");
            Console.WriteLine($"Useer Id: [{id}] Name [{userName}] with passsword [{userPassword}].");
            Console.WriteLine("Press any key.");
            Console.ReadKey();
        }
    }
}
