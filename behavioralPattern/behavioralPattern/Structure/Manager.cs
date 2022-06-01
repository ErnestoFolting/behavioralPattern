using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioralPattern.Structure
{
    internal class Manager
    {
        List<EventListeners> Listeners = new List<EventListeners>();
        public void subscribe(EventListeners listener)
        {
            Listeners.Add(listener);
        }
        public void unsubscrive(EventListeners listener)
        {
            Listeners.Remove(listener);
        }
        public void notify(Invoice invoice)
        {
            bool flag = false;
            foreach (EventListeners listener in Listeners)
            {
                if(invoice.recipientPhoneNumber == listener.phoneNumber)
                {
                    flag = true;
                    listener.update(invoice);
                }
            }
            if (!flag)
            {
                Console.WriteLine("There is no subscriber. \n");
            }
        }
    }
}
