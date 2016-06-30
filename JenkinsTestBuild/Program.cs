using JenkinsTestBuild.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JenkinsTestBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test Jenkins ");
            Console.WriteLine("test Jenkins update ");
            Console.WriteLine("test Jenkins update with dépendance '"+ (new ServiceTest().test()) +"' ");
            Console.ReadKey();



        }
    }
}
