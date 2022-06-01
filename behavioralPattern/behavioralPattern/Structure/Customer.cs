using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioralPattern.Structure
{
    internal class Customer:EventListeners
    {
        public string surname { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }

        public void update(Invoice data)
        {
            Console.WriteLine("{0} invoice number was sent to {1} {2}\nTotal price: {3}\n", data.id,surname,name,data.orderPrice+data.deliveryPrice);
            
        }
    }
}
