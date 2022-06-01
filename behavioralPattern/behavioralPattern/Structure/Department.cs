using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioralPattern.Structure
{
    internal class Department
    {
        public List<Invoice> invoices = new List<Invoice>();
        public Manager manager;
        public void addInvoices(List<Invoice> lst)
        {
            Console.WriteLine("Added {0} invoices\n", lst.Count);
            invoices.AddRange(lst);
        }
        public void storageInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Storage:\n");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var invoice in invoices)
            {
                invoice.getInfo();
            }
        }
        public void sendInvoice(Invoice invoice)
        {
            if (invoices.Contains(invoice))
            {
                invoices.Remove(invoice);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1 invoice was sent\n");
                Console.ForegroundColor = ConsoleColor.White;
                manager.notify(invoice);
            }
            else
            {
                Console.WriteLine("Missing that invoice on storage.");
            }
            
        }
    }
}
