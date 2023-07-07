using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarProject_
{
    internal class Car
    {
        public string Color { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }

        static Random random = new Random();

        

        public static string RandomCarNumber()
        {

            string randNum = $"{(char)random.Next(65, 90)}{(char)random.Next(65, 90)}-{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}-{(char)random.Next(65, 90)}{(char)random.Next(65, 90)}";

            return randNum;
        }





    }
}
