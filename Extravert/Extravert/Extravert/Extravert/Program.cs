using System.Collections.Generic;
using System.Text;

string greeting = @"Welcome to Plant it Again!
Where we dig weird plants";

Console.WriteLine(greeting);

List<Plant> plants = new List<Plant>()
{
    new Plant()
    {
        Name = "Wolfear",
        LightNeeds = 3,
        AskingPrice = (int)3.00M,
        City = "Tampa",
        Zip = 33579,
        Sold = false
    },

    new Plant()
    {
        Name = "BlueLip",
        LightNeeds = 1,
        AskingPrice = (int)12.00M,
        City = "Tampa",
        Zip = 33579,
        Sold = false
    },

    new Plant()
    {
        Name = "Brightwing",
        LightNeeds = 4,
        AskingPrice = (int)15.00M,
        City = "Tampa",
        Zip = 33579,
        Sold = false
    },

    new Plant()
    {
        Name = "Trollup",
        LightNeeds = 2,
        AskingPrice = (int)19.00M,
        City = "Tampa",
        Zip = 33579,
        Sold = false
    },

    new Plant()
    {
        Name = "Streanan",
        LightNeeds = 5,
        AskingPrice = (int)5.00M,
        City = "Tampa",
        Zip = 33579,
        Sold = false
    }
};
DisplayMenu(plants);
Console.WriteLine("Please enter a menu option: ");
void DisplayMenu(List<Plant> plants)
{
    string choice = null;
    while (choice != "0")
    {
        Console.WriteLine(@"Choose an option: 
                        0. Exit
                        1. Display All Plants
                        2. Post a plant for sale
                        3. Buy a plant
                        4. Update a plant");
        choice = Console.ReadLine();
        if (choice == "0")
        {
            Console.WriteLine("Peace Out!");
        }
        else if (choice == "1")
        {
            DisplayAllPlants();
        }
        else if (choice == "2")
        {
            PostAPlant(plants);
        }
        else if (choice == "3")
        {
            throw new Exception("Adopt a plant");
        }
        else if (choice == "4")
        {
            throw new Exception("Delist a Plant");
        }
    }
   
}
void DisplayAllPlants()
{

    Console.WriteLine("Our Plant Inventory");

    for (int i = 0; i < plants.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {plants[i].Name}");
    }

    
    DisplayMenu(plants);
}

void PostAPlant(List<Plant> plants)
{
    Console.WriteLine("Name of weird plant you would like to list for adoption: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Light needs of the plant 1-5 with 5 being the most sun: ");
    int LightNeeds = int.Parse(Console.ReadLine());
    Console.WriteLine("Asking price: ");
    double AskingPrice = double.Parse(Console.ReadLine());
    Console.WriteLine("City plant located in: ");
    string City = Console.ReadLine();
    Console.WriteLine("Zip code: ");
    int Zip = int.Parse(Console.ReadLine());
    Console.WriteLine("Plant Sold? Y or N: ");
    bool Sold = bool.Parse(Console.ReadLine());

    Plant newPlant = new Plant
    {
        Name = Name,
        LightNeeds = LightNeeds,
        AskingPrice = AskingPrice,
        City = City,
        Zip = Zip,
        Sold = Sold

    };

    plants.Add(newPlant);
    DisplayAllPlants();
}
