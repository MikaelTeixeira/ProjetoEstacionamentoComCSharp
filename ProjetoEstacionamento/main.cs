using ProjetoEstacionamento.Models;
    Parking parking = new Parking();
    Car userCar = null;
    
do
{
    int decision = CRUDS.FirstCrud();

    switch (decision)
    {

        case 1: //Show all cars in the parking
            parking.ShowCarsInPark();
            break;

        case 2: //Register a new car

            userCar = Car.RegisterCar();

            Console.WriteLine("\nCongratulations! your car is alredy registered!");
            break;

        case 3: //See and select a free spot to add a car

            bool validDecision = false;

            parking.GetFreeSpots();

            Console.WriteLine("\nDid you want to take a spot?\n(Y/N):");
            string spotInput = Console.ReadLine();

            if (spotInput.ToLower() == "n")
            {
                Console.Clear();
                break;
            }
            else if (spotInput.ToLower() == "y")
            {
                Console.Clear();
                validDecision = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please, try again.");
                continue;
            }


            if (validDecision == true && userCar != null)
            {
                bool spotVerification = parking.SearchCarInParking(userCar);

                if (spotVerification == true)
                {
                    Console.WriteLine("\nYour car alredy ocupies a spot on our parking. You can register other car to park.");
                    break;
                }

                Console.WriteLine("\nGreat! Please, select one of the free spots:");
            }
            else if (validDecision == true && userCar == null)
            {
                Console.WriteLine("\nYou need to register a car first.");
                userCar = Car.RegisterCar();
            }

            string selectedSpot = parking.ChooseSpot();
            userCar.Position = selectedSpot;
            parking.AddCarInParking(userCar);

            Console.WriteLine($"Alright!, your car now occupies the spot {selectedSpot}.");
            break;

        case 4: //See how much time a car has been parked

            bool feeCalcVerification = false;
            do
            {
                Console.WriteLine("\nType the name of the car you want to check:");
                string carName = Console.ReadLine();

                Console.WriteLine("\nType the year of the car you want to check:");
                string yearInput = Console.ReadLine();
                int carYear;

                if (int.TryParse(yearInput, out carYear) == false)
                {
                    Console.WriteLine("\nInvalid year, please, try again.");
                    continue;
                }


                foreach (var car in parking.CarsInPark)
                {
                    if (car.Name.ToLower() == carName.ToLower() && car.Year == carYear)
                    {
                        feeCalcVerification = true;
                        break;
                    }
                }

                if (!feeCalcVerification)
                {
                    Console.WriteLine($"\nWe don't have a car {carName} {carYear} on our parking.");
                    break;
                }


            } while (feeCalcVerification == false);

            decimal feePrice = parking.CalculateFee(userCar);
            Console.Clear();
            Console.WriteLine($"\nThe fee for the car {userCar.Name} is: {feePrice:C}");
            break;

        case 5: //Remove a car from the parking
            bool carRemoved = false;
            do
            {

                Console.WriteLine("\nType the car name:");
                string carNameToRemove = Console.ReadLine();

                Console.WriteLine("\nType the car's year number: ");
                string strCarYear = Console.ReadLine();
                int parkedCarYear;

                if (int.TryParse(strCarYear, out parkedCarYear) == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid year, please, try again.\n");
                    continue;
                }

                bool resultOfSearch = parking.SearchCarInParking(carNameToRemove, parkedCarYear);

                if (resultOfSearch)
                {
                    Console.Clear();
                    parking.RemoveCar(parkedCarYear);
                    Console.WriteLine($"\nThe car {carNameToRemove} {parkedCarYear} was removed from the parking.");
                }

            } while (carRemoved == false);

            // case 6:

    }
} while (true);