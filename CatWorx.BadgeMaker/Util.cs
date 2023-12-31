using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util 
    {
        public static void PrintEmployees(List<Employee> employees) 
        {
            for (int i = 0; i < employees.Count; i++)
            {
            string template = "{0,-10}\t{1,-20}\t{2}";
            Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }
        public static void  MakeCSV(List<Employee> employees)
        {
            if (!Directory.Exists("data")) //checks if data folder exists
            {
                Directory.CreateDirectory("data");
            }

            using(StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                // Loop over employees
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0}, {1}, {2}";
                    // file.writeline all the employee data
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
                }
            }
        }
    }
}