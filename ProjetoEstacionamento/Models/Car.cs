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

        public int Year { get; set; }

        public bool CarInPark { get; set; }


        public decimal ParkingFee { get; set; }

        public double TimeSpent { get; set; }


        public bool VerifyCar()
        {
            return CarInPark;
        }

        // public decimal CalculateFee()
        // {
        //     if (TimeSpent <= 1)
        //     {
        //         return 5.50M;
        //     }
        //     else if (TimeSpent > 1 && TimeSpent < 1.5)
        //     {
        //         return 6.75M;
        //     }
        //     else if (TimeSpent >= 1.5 && TimeSpent < 3)
        //     {
        //         return 7.25M;
        //     }
        //     else
        //     {
        //         return 10.00M;
        //     }
        // }

    }
}