using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


namespace KnowledgeCheck2
{
    public class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(int vehicleId) 
        {
            VehicleId = vehicleId;
        }

        public int VehicleId { get; private set; }
        public string? State { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public string? drivetrainType { get; set; }

        public Vehicle Retrieve(int VehicleId)
        {
            return new Vehicle();
        }
        public bool Save()
        {
            return true;
        }

        public bool Validate() //exception handling
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(State)) isValid = false; 
            if (string.IsNullOrWhiteSpace(Model)) isValid = false; 
            if (string.IsNullOrWhiteSpace(Color)) isValid = false;
            if (string.IsNullOrWhiteSpace(drivetrainType)) isValid = false;

            return isValid;
        }
    }
}