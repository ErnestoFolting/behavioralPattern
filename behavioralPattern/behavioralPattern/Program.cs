using System;
using System.Collections.Generic;
using behavioralPattern.Structure;

namespace behavioralPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create TextBooks
            TextBook newspaper1 = new Newspaper("Author1", "Title1", 30);
            TextBook magazine1 = new Magazine("Author1", "Title1", 1, 70);

            //Create list of TextBooks
            List<TextBook> lst1 = new List<TextBook>() { newspaper1, magazine1 };
            List<TextBook> lst2 = new List<TextBook>() { newspaper1 };
            List<TextBook> lst3 = new List<TextBook>() { magazine1 };

            //Create invoices 
            Invoice invoice1 = new Invoice(lst1, "+380637393034");
            Invoice invoice2 = new Invoice(lst2, "+380679702280");
            Invoice invoice3 = new Invoice(lst3, "+380689702230");

            //Create register of invoices
            List<Invoice> invoiceLst = new List<Invoice> { invoice1, invoice2, invoice3 };

            //Create department with event manager and subscribe customers to events
            Department department = new Department();
            Manager manager = new Manager();
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            customer1.surname = "Pylypenko";
            customer1.name = "Nazar";
            customer1.phoneNumber = "+380637393034";
            manager.subscribe(customer1);
            customer2.surname = "Andrienko";
            customer2.name = "Semen";
            customer2.phoneNumber = "+380689702230";
            manager.subscribe(customer2);
            department.manager = manager;

            //Department work
            department.addInvoices(invoiceLst);
            department.storageInfo();
            department.sendInvoice(invoice1);
            department.storageInfo();
            department.sendInvoice(invoice2);
            department.storageInfo();
            department.sendInvoice(invoice3);
            department.storageInfo(); 
        }
    }
}