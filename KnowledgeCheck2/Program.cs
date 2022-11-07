using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace KnowledgeCheck2
{ 
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Register your vehicle online today! Please press enter to begin.");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Let's gather some basic information to get you started today. Press enter to begin.");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("How many cars do you want to register today?");
            var numberOfRecords = int.Parse(Console.ReadLine()!);
            var carRecordList = new List<car>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                var car = new car();

                Console.WriteLine("What state did you originally purchase your car?:");
                car.State = Console.ReadLine();
                if (car.State == "")
                {
                    Console.WriteLine("Please enter a valid state and try again.");
                    return;
                }

                Console.WriteLine("Is your car's drivetrain AWD, RWD, or FWD?:");
                car.Name = Console.ReadLine();
                if (car.Name == "")
                {
                    Console.WriteLine("Please type AWD, RWD, or FWD and try again.");
                    return;
                }

                Console.WriteLine("Please type the make of your car: ");
                car.Name = Console.ReadLine();
                if (car.Name == "")
                {
                    Console.WriteLine("That is not a valid car make, try again please.");
                    return;
                }

                Console.WriteLine("Please enter the model of your car:");
                car.Model = Console.ReadLine();
                if (car.Model == "")
                {
                    Console.WriteLine("You did not enter a valid model, please try again.");
                    return;
                }

                Console.WriteLine("Enter the year:");
                car.Year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Add the color of your car:");
                car.Color = Console.ReadLine();
                if (car.Color == "")
                {
                    Console.WriteLine("Please enter a valid car color and try again!");
                    return;
                }

                carRecordList.Add(new car()
                {
                    State = car.State,
                    Drivetrain = car.Drivetrain,
                    Name = car.Name,
                    Model = car.Model,
                    Color = car.Color,
                    Year = car.Year,
                });
            }
            foreach (var car in carRecordList)
            {
                Console.WriteLine(
                    $"Thank you for registration: {car.State}{car.Drivetrain}, {car.Name}, {car.Model}, {car.Year}, {car.Color}.");
            }  
            Console.WriteLine(" ");
            Console.WriteLine("Please check your email for the next set of instructions. Have a nice day.");
            Console.ReadKey();
            }
        }
    }