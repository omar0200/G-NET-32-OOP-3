using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_32_OOP_3
{
    internal class IMAXTicket : Ticket
    {
        public IMAXTicket(string moviename, decimal price,bool is3d) : base(moviename, price)
        {
            Is3d = is3d;
        }
        public bool Is3d { get; set; }

        public decimal finalprice {
            get
            {
                if (Is3d)
                {
                    return PriceAfterTax + 30;

                }
                else return PriceAfterTax;
            }
            }

        public override string ToString() => $"Moviename > {MovieName}, price > {PriceAfterTax}, Is3D >{Is3d}";

    }

}
	

