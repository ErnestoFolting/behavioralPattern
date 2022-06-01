using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace behavioralPattern.Structure
{
    internal class Invoice
    {
        public int id { get; set; }
        public List<TextBook> textBooks  = new List<TextBook>();
        public int orderPrice { get; }
        public int deliveryPrice { get; }
        
        public string recipientPhoneNumber { get; set; }

        public Invoice(List<TextBook> lst, string recipientPhoneNumber)
        {
            var rand = new Random();
            this.id = rand.Next(10000) + 10000;
            this.textBooks = lst;
            this.recipientPhoneNumber = recipientPhoneNumber;
            this.orderPrice = lst.Select(el => el.Price).Sum();
            this.deliveryPrice = (rand.Next(5) + 5) * 10;

        }
        public void getInfo()
        {
            Console.WriteLine(" Invoice info: \nId: {0}\nRecipient phone number:{1}\nItems count: {2}\nOrder price: {3}\nDelivery price: {4}\n", id, recipientPhoneNumber, textBooks.Count,orderPrice,deliveryPrice);
        }
    }
}
