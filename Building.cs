using System;

namespace Planner
{
    class Building
    {
        //privet
        private string _designer { get; set; }
        private DateTime _dateConstructed { get; set; }
        private string _address { get; set; }
        private string _owner { get; set; }
        //public
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        //read only
        public string Volume
        {
            get
            {
                return $"{Width} * {Depth} * {Stories} * 3";
            }
        }
        //constructor
        public Building(string address)
        {
            _address = address;
        }
        //methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string buyerName)
        {
            buyerName = _owner;
        }
    }
}