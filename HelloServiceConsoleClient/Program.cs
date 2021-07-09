using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HelloServiceConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput= Menu();
            TakeAction(userInput);
        }

        private static void TakeAction(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    WelcomeMessage();
                    // code block
                    break;
                case 2:
                    // code block
                    break;
                case 3:
                    // code block
                    break;
            }
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            HelloService.HelloServiceClient serviceClient = new HelloService.HelloServiceClient("NetTcpBinding_IHelloService");
            Console.WriteLine(serviceClient.GetMessage(name));
            Console.ReadLine();

        }

        private static int Menu()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("Sample Console  Application");
            Console.WriteLine("****************************************");
            Console.WriteLine("1. Welcome Message");
            Console.WriteLine("2. Get Data");
            Console.WriteLine("3. Exit");
            string key = Console.ReadLine();
            return Convert.ToInt32(key);
        }
    }
}
