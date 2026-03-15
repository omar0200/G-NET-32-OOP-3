using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_32_OOP_3
{
    internal class Ticket
    {
        private static int ticketcounter = 0;
        private decimal price;
        private int ticketid;
        private decimal pricetax;
        public string MovieName { get; set; }
        public  decimal Price{
            get;
            set { if (value > 0) price = value; }       
        }
        public int TicketId { get { return ticketid; }
        }
       

        public decimal PriceAfterTax
        {
            get { return price + (price * 0.14m); }
          
        }

        public Ticket(string moviename , decimal price)
        {
            ++ticketcounter;
            ticketid = ticketcounter;
            MovieName = moviename;
            Price = price;
        }
        public override string ToString() =>  $"Moviename > {MovieName}, price > {PriceAfterTax}";
        


    }
}
