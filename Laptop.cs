using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15_assign_18
{
    public class Laptop : IConnectable, IReachargeable, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryPercentage { get; private set; }
        

        public Laptop(string model)
        {
            Model = model;
            IsConnected = false;
            BatteryPercentage = 0;
           
        }

        public bool Connect()
        {
            // Implementation for IConnectable
            IsConnected = true;
            Console.WriteLine($"Laptop {Model} is now connected.");
            return true;
        }

        public void Charge(int minutes)
        {
            // Implementation for IRechargeable
            BatteryPercentage += minutes / 5;
            if (BatteryPercentage > 100)
                BatteryPercentage = 100;
            Console.WriteLine($"Laptop {Model} is charged for {minutes} minutes. Battery Percentage: {BatteryPercentage}%");
        }

        public string Display()
        {
            // Implementation for IDisplayable
            return $"Laptop {Model}: Connected: {IsConnected}, Battery Percentage: {BatteryPercentage}%";
        }
    }
}
