using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Vehicle
    {
        public virtual int height { set; get; }
        public virtual int price { set; get; }
        public virtual int speed { set; get; }
        public virtual int year { set; get; }
        public virtual int passengers { set; get; }
        public virtual string type { set; get; }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Vehicle Info:\n");
        }

    }
}
