using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle plane = new Plane()
            {
                type = "Plane",
                passengers = 2,
                planeName = "як-130",
                speed = 350,
                height = 2500,
                year = 2009,
                price = 100000000
            };
            Vehicle ship = new Ship()
            {
                type = "Ship",
                passengers = 600,
                shipName = "LOIUS OLYMPIA",
                speed = 50,         
                year = 2000,
                price = 423523422,
                port = "Port Belmentone"
            };
            plane.ShowInfo();
            ship.ShowInfo();
        }
    }
}
