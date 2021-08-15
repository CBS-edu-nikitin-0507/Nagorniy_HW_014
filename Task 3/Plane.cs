using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Plane : Vehicle
    {
        public string planeName { set; get; }     
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Vehicle Type: {type}\nName: {planeName}\nYear of issue: {year}\nPassengers: {passengers}\nSpeed: {speed}Km\nHigh :{height}m\nPrice: {price}$");
        }

    }
}
