using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    public class Parking
    {
        public List<string> FreeSpotsA { get; set; } = new List<string> { "A1", "A2", "A3", "A4", "A5" };

        public List<string> FreeSpotsB { get; set; } = new List<string> { "B1", "B2", "B3", "B4", "B5" };

        public List<string> FreeSpotsC { get; set; } = new List<string> { "C1", "C2", "C3", "C4", "C5" };

        public List<string> OccupiedSpots { get; set; } = new List<string>();

        public List<Car> CarsInPark { get; set; } = new List<Car>();

        public decimal CalculateFee(Car userCar) //FUNCIONANDO CORRETAMENTE
        {
            double TimeSpent = userCar.TimeSpent ?? 0;
            if (TimeSpent <= 1)
            {
                return 5.50M;
            }
            else if (TimeSpent > 1 && TimeSpent < 1.5)
            {
                return 6.75M;
            }
            else if (TimeSpent >= 1.5 && TimeSpent < 3)
            {
                return 7.25M;
            }
            else
            {
                return 10.00M;
            }
        }

        public void ShowCarsInPark() //FUNCIONANDO CORRETAMENTE
        {

            if (CarsInPark.Count == 0)
            {
                Console.WriteLine("No cars in the parking.");
                return;
            }

            Console.WriteLine("All cars in the parking: ");


            foreach (var car in CarsInPark)
            {
                Console.WriteLine($"\n- {car.Name} {car.Year} | Vaga ocupada: {car.Position}");
            }

        }

        public void GetFreeSpots() //FUNCIONANDO CORRETAMENTE
        {

            if (FreeSpotsA.Count() == 0 && FreeSpotsB.Count() == 0 && FreeSpotsC.Count() == 0)
            {
                Console.Write("\nSorry, we don't have any free spots right now. Please, come back later.");
                return;
            }

            Console.WriteLine("\n");

            foreach (var spot in FreeSpotsA)
            {
                Console.Write($" {spot}");
            }

            Console.WriteLine("\n");

            foreach (var spot in FreeSpotsB)
            {
                Console.Write($" {spot}");
            }

            Console.WriteLine("\n");

            foreach (var spot in FreeSpotsC)
            {
                Console.Write($" {spot}");
            }

            Console.WriteLine("\n");

        }

        public string? ChooseSpot() //FUNCIONANDO CORRETAMENTE
        {

            bool mistake = true;

            string decision = null;

            do
            {

                this.GetFreeSpots();
                Console.WriteLine("Choose the spot you want to rest your car:");
                decision = Console.ReadLine();

                if (!this.FreeSpotsA.Contains(decision.ToUpper()) && !this.FreeSpotsB.Contains(decision.ToUpper()) && !this.FreeSpotsC.Contains(decision.ToUpper()))
                {
                    Console.Clear();
                    Console.WriteLine("This spot is not available, please, choose a valid spot");

                    mistake = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nCongratulations!");
                    mistake = false;
                }


            } while (mistake == true);
            return decision.ToUpper();
        }

        public void RemoveCar(string Spot) //FUNCIONANDO CORRETAMENTE
        {

            if (Spot.StartsWith("A"))
            {
                FreeSpotsA.Add(Spot);
            }
            else if (Spot.StartsWith("B"))
            {
                FreeSpotsB.Add(Spot);
            }
            else if (Spot.StartsWith("C"))
            {
                FreeSpotsC.Add(Spot);
            }
            else
            {
                Console.WriteLine("Invalid spot. Please, choose a valid one.");
                return;
            }

            OccupiedSpots.Remove(Spot);

            foreach (var userCar in CarsInPark)
            {
                if (userCar.Position == Spot)
                {
                    CarsInPark.Remove(userCar);
                    break;
                }
            }
        }

        public bool AddCarInParking(Car userCar) //FUNCIONANDO CORRETAMENTE
        {
            if (userCar.Position == null)
            {
                return false;
            }
            else
            {
                CarsInPark.Add(userCar);

                if (userCar.Position.StartsWith("A"))
                {
                    FreeSpotsA.Remove(userCar.Position);
                }
                else if (userCar.Position.StartsWith("B"))
                {
                    FreeSpotsB.Remove(userCar.Position);
                }
                else if (userCar.Position.StartsWith("C"))
                {
                    FreeSpotsC.Remove(userCar.Position);
                }

                OccupiedSpots.Add(userCar.Position);
            }
            return true;
        }

        public bool SearchCarInParking(Car userCar) //FUNCIONANDO CORRETAMENTE
        {
            if (this.CarsInPark.Any(Car => Car.Name == userCar.Name && Car.Year == userCar.Year))
            {
                return true;
            }
            return false;
        }

    }
}