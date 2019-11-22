using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 10;
            FiveOneTwoEigth.Depth = 10;
            FiveOneTwoEigth.Stories = 3;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Josh Dude");

            Building batmanBuilding = new Building("123 Batman Street");
            FiveOneTwoEigth.Width = 12;
            FiveOneTwoEigth.Depth = 12;
            FiveOneTwoEigth.Stories = 33;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Rebecca black");

            Building theCapitol = new Building("5234 Government Way");
            FiveOneTwoEigth.Width = 17;
            FiveOneTwoEigth.Depth = 160;
            FiveOneTwoEigth.Stories = 6;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("The Best Government person ever");

            City Nashville = new City("Nashville");
            Nashville.AddBuilding(FiveOneTwoEigth);
            Nashville.AddBuilding(batmanBuilding);
            Nashville.AddBuilding(theCapitol);
            Nashville.PrintBuildings();
        }
    }
}
