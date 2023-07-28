using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_15_assign_18
{
    public class Smartphone : IConnectable, IReachargeable, IDisplayable
    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryPercentage { get; private set; }
       

        public Smartphone(string model)
        {
            Model = model;
            IsConnected = false;
            BatteryPercentage = 0;
           
        }

        public bool Connect()
        {
            // Implementation for IConnectable
            IsConnected = true;
            Console.WriteLine($"Smartphone {Model} is now connected.");
            return true;
        }

        public void Charge(int minutes)
        {
            // Implementation for IReachargeable
            BatteryPercentage += minutes / 10;
            if (BatteryPercentage > 100)
                BatteryPercentage = 100;
            Console.WriteLine($"Smartphone {Model} is charged for {minutes} minutes. Battery Percentage: {BatteryPercentage}%");
        }

        public string Display()
        {
            // Implementation for IDisplayable
            return $"Smartphone {Model}: Connected: {IsConnected}, Battery Percentage: {BatteryPercentage}%";
        }
    }
}
