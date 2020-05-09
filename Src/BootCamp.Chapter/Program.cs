using Microsoft.VisualBasic;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name: ");
            var Name = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            var Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Weight in KG: ");
            var Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height in CM: ");
            var Height = Convert.ToDouble(Console.ReadLine());
            double BodyMassIndex = (int)Math.Floor((Weight / (Height/100)) / (Height/100)) ;
          
            Console.WriteLine(Name + " is " + Age + " years old, their weight is " + Weight + " kg and their height is "  + Height + " metres.");
            Console.ReadKey();
            Console.WriteLine("Their BMI is " + BodyMassIndex + ".");
        }
    }
}
