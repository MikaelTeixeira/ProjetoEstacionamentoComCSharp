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



        public static Car RegisterCar(string name, string color, int year, double timespent, string position) //FUNCIONANDO CORRETAMENTE
        {
            Car newCar = new Car()
            {
                Name = name,
                Color = color,
                Year = year,
                TimeSpent = timespent,
                Position = position
            };
            return newCar;
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