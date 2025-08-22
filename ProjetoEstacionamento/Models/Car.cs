using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Car
    {
        public string? Name { get; set; } = string.Empty;

        public string? Color { get; set; } = string.Empty;

        public int? Year { get; set; }

        public double? TimeSpent { get; set; }

        public string? Position { get; set; } = string.Empty;



        public static Car RegisterCar() //FUNCIONANDO CORRETAMENTE
        {
            bool stop = false;
            Car userCar = null;

            do
            {            
                int carYear = 0;
                string carName = "";
                string carColor = "";

                bool nameVerification = false;
                bool colorVerification = false;
                bool yearVerification = false;

                double timeSpent = 1;
                string position = "";

                do //NAME LOOP VERIFICATION - RUNNING
                {
                    Console.WriteLine("\nType your car name:");
                    carName = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine($"\nIs this the correct name '{carName}'?\n [y] [n]:");
                    string confirmation = Console.ReadLine();

                    if (confirmation.ToLower() == "y")
                    {
                        nameVerification = true;
                    }
                    else if (confirmation.ToLower() == "n")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid option, please, choose a valid one.");
                    }
                } while (nameVerification == false);

                do //COLOR LOOP VERIFICATION - RUNNING
                {
                    Console.WriteLine("\nType your car color:");
                    carColor = Console.ReadLine();

                    if (carColor.Length == 0)
                    {
                        Console.WriteLine("\nPlease, type a valid color. This is important");
                    }
                    else
                    {
                        colorVerification = true;
                    }

                } while (colorVerification == false);

                do //YEAR LOOP VERIFICATION - RUNNING
                {
                    Console.WriteLine("\nType your car Year:");
                    string strCarYear = Console.ReadLine();
                    carYear = 0;

                    bool tryConvert = int.TryParse(strCarYear, out carYear);

                    if (tryConvert == false)
                    {
                        Console.WriteLine("\nPlease, type a valid year. This is important");
                    }
                    yearVerification = true;
                } while (yearVerification = false);
            
            userCar = new Car()
            {
                Name = carName,
                Color = carColor,
                Year = carYear,
                TimeSpent = timeSpent,
                Position = null
            };

            stop = true;

            } while (stop == false); 
            return userCar;
        }

        public static Car UpdateTimeSpent(double timespent, Car userCar) //FUNCIONANDO CORRETAMENTE
        {
            userCar.TimeSpent = timespent;
            return userCar;
        }

        public static Car UpdatePosition(string position, Car userCar) // FUNCIONANDO CORRETAMENTE
        {
            userCar.Position = position;
            return userCar;
        }
    }

}