using System;
using System.Collections.Generic;

namespace RoomHierarchy
{
    public enum HeatingSystem
    {
        NoHeating,
        WaterHeating,
        AirHeating,
        ElectricHeating
    }

    public class LivingQuarter : Room, ISmartHome
    {
        public HeatingSystem HeatingSystem { get; set; }
        public List<Item> Items { get; set; }
        
        public LivingQuarter()
        {
            HeatingSystem = HeatingSystem.NoHeating;
            Items = new List<Item>();
        }

        public LivingQuarter(string roomName, string roomDescription, double ceilingHeight, double length, double width,
            bool windowsPresence, bool electricitySupply, SiteInfo siteInfo, HeatingSystem heatingSystem,
            List<Item> items) : base(roomName, roomDescription, ceilingHeight, length, width, windowsPresence,
            electricitySupply, siteInfo)
        {
            HeatingSystem = heatingSystem;
            Items = new List<Item>(items);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
        
        public void SetHeatingSystem(HeatingSystem heatingSystem)
        {
            HeatingSystem = heatingSystem;
        }

        public override void MakeRepairs()
        {
            Console.WriteLine("Doing repair in the living quarter!");
        }

        public void ConfigureSystem()
        {
            Console.WriteLine("Configure the SMART HOME system");
            Console.WriteLine("1) Checking WIFI connection...");
            Console.WriteLine("2) Checking for system updates...");
            Console.WriteLine("3) Detecting all available sensors...");
        }

        public void AnalyzeSensors()
        {
            Console.WriteLine("Analyzing sensor data...");
        }

        public void SetupSensors()
        {
            Console.WriteLine("Setting up new sensor...");
        }
    }
}