using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            TestController.GetWebsiteList();
            TestController.GetAudienceQueryList();
            Console.ReadLine();
        }
    }
}
