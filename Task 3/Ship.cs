using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Ship : Vehicle
    {
        public string port { set; get; }
        public string shipName { set; get; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Vehicle Type: {type}\nName: {shipName}\nYear of issue: {year}\nPassengers: {passengers}\nSpeed: {speed}Km\nPort: {port}\nPrice: {price}$");
        }

    }
}
