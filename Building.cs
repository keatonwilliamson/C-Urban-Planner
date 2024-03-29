using System;

namespace UrbanPlanner
{
    class Building
    {
        public Building(string address)
        {
            _address = address;
        }
        private string _designer = "Keaton Williamson";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
        public void Construct()
        {
             _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner)
        {
             _owner = owner;
        }
        public void Print()
        {
            Console.WriteLine(_address);
            Console.WriteLine("----------------------");
            Console.WriteLine("Designed by " + _designer);
            Console.WriteLine("Constructed on " + _dateConstructed);
            Console.WriteLine("Owned by " + _owner);
            Console.WriteLine(Volume + " meters of space");
            Console.WriteLine();

        }
    }
}