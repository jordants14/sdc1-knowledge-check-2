using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeCheck2
{
    public class car : Vehicle
    {
        public car()
        {

        }
        public car(int carId)
        {
            carId = carId;
        }
        public int carId { get; private set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public string? Drivetrain { get; set; }
        public List<car> Retrieve() //gets a full list of vehicles
        {
            return new List<car>();
        }
    }
}