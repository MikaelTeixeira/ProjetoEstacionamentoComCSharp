using ProjetoEstacionamento.Models;

Car userCar = new Car()
{
    Name = "Fusca",
    Year = 1970,
    Color = "Blue",
};


    Parking park = new Parking();
    
do
{
    int decision = CRUDS.FirstCrud();

    switch (decision)
    {

        case 1:
            park.ShowCarsInPark();
        case 2:
            park.GetFreeSpots();
        case 3:
            newCar = Car.RegisterCar();
        case 4:

        case 5:

        case 6:
    }
} while (true);