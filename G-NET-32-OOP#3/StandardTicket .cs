using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_32_OOP_3
{
    internal class StandardTicket : Ticket
    {
        public string seatnumber { get; set; }
        public StandardTicket(string moviename, decimal price, string Seat) : base(moviename, price)
        {
            seatnumber = Seat;
        }
        public override string ToString() => $"Moviename > {MovieName}, price > {PriceAfterTax}, seat {seatnumber}";

    }
}
