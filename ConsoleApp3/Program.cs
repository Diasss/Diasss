using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Modal
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceUser serviceUser = new ServiceUser("https://randomuser.me/api?results%20=%201");
            Console.WriteLine(serviceUser.GetJsonString());
        }
    }
}
