using System;
using System.Collections.Generic;

namespace behavioralPattern.Structure
{
    public abstract class TextBook
    {
        public string Author;
        public string Title;
        public int Price;
        public abstract void getInfo();
        public TextBook(string author, string title, int price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
    }
    class Newspaper : TextBook
    {
        public Newspaper(string author, string title, int price) : base(author, title, price) { }
        public override void getInfo()
        {
            Console.WriteLine(" Newspaper info: \nTitle: {0}\nAuthor: {1}\nPrice: {2}\n", Title, Author, Price);
        }
    }
    class Magazine : TextBook
    {
        public int Number;
        public Magazine(string author, string title, int number, int price) : base(author, title, price)
        {
            this.Number = number;
        }
        public override void getInfo()
        {
            Console.WriteLine(" Magazine info: \nTitle: {0}\nNumber: {1}\nAuthor: {2}\nPrice: {3}\n", Title, Number, Author, Price);
        }
    }
}