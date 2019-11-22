using System;
using System.Collections.Generic;

namespace UrbanPlanner
{
    class City
    {
        public City(string cityName)
        {
            _cityName = cityName;
        }
        private string _cityName;
        private int _yearEstablished;
        private string _mayor;
        private List<Building> buildings = new List<Building>();
        public void Establish()
        {
             _yearEstablished = DateTime.Now.Year;
        }
        public void AddBuilding(Building building)
        {
             buildings.Add(building);
        }
        public void PrintBuildings()
        {
             buildings.ForEach(building => building.Print());
        }
        public void AddMayor(string mayor)
        {
             _mayor = mayor;
        }
    }
}