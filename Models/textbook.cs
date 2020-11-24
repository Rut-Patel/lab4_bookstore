using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab4_bookstore.Models
{
    public class textbook
    {
        public string title { get; set; }
        public int ISBN { get; set; }
        public string version { get; set; }
        public double price { get; set; }
        public string condition { get; set; }

        public textbook()
        {

        }

        public textbook(string title,int ISBN, string version,double price,string condition)
        {
            this.title = title;
            this.ISBN = ISBN;
            this.version = version;
            this.price = price;
            this.condition = condition;
        }

        public double appraisalPrice(double price,string condition)
        {
            double finalPrice;

           if(condition == "Bad")
           {
                finalPrice = price / 4;
           }
           else if(condition == "Good")
           {
                finalPrice = price / 3;
           }
           else
           {
                finalPrice = price / 2;
           }
           
            return Math.Round(finalPrice,2);
        }

        public override string ToString()
        {
            return "Hello, your book: " + this.title + " version: " + this.version + " and with ISBN: " + this.ISBN + " can be appraised at: $" + appraisalPrice(price,condition) ;
        }
    }
}
