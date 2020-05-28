using System;

namespace Planner
{
    class Building
    {
        private string _designer { get; set; } = "Philip Martin";
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }

        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * Stories * 3;
            }
        }
        //constructor
        public Building(string address)
        {
            _address = address;
        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        public void Done()
        {
            Console.WriteLine(_address);
            Console.WriteLine("-----------");
            Console.WriteLine($"Designed By {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned By {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
        }
    }
}
