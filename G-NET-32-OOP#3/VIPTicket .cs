using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_32_OOP_3
{
    internal class VIPTicket : Ticket
    {
        private bool loungeAccess { get; set; }
        private decimal servicefee = 50;
        public VIPTicket(string moviename, decimal price,bool loungAccess) : base(moviename, price)
        {
            loungeAccess = loungAccess;
        }
        public override string ToString() => $"Moviename > {MovieName}, price > {PriceAfterTax}, Loungaccess >{loungeAccess}";

    }
}
