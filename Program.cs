using System;
using System.Collections.Generic;
using Planner;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building myBuilding = new Building("512 8th Ave");

            myBuilding.Width = 200;
            myBuilding.Depth = 1000;
            myBuilding.Stories = 10;
            myBuilding.Construct();
            myBuilding.Purchase("Nathan Caldwell");
            myBuilding.Done();

            Building yourBuilding = new Building("643 3th Blvd");

            yourBuilding.Width = 300;
            yourBuilding.Depth = 2000;
            yourBuilding.Stories = 20;
            myBuilding.Construct();
            myBuilding.Purchase("Hannah Khan");
            myBuilding.Done();

            Building theirBuilding = new Building("7321 2th St");

            theirBuilding.Width = 400;
            theirBuilding.Depth = 3000;
            theirBuilding.Stories = 30;
            myBuilding.Construct();
            myBuilding.Purchase("Michael Martin");
            myBuilding.Done();
        }
    }
}