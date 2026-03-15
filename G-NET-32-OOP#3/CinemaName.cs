using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_32_OOP_3
{
    internal class CinemaName
    {
        private Ticket[] _ticket = new Ticket[20];
        private Projector projector;    
        public CinemaName()
        {
             projector = new Projector();  
        }

        public Ticket this[int index]
        {
            get { return _ticket[index]; }
          
        }

        public void addticket (Ticket t)
        {
            for (int i = 0; i < _ticket.Length; i++)
            {
                if (_ticket[i] == null)
                {
                    _ticket[i] = t;
                    break;
                }
            }
        }
        public void printalltickets()
        {
            for (int i=0;i<_ticket.Length; i++)
            {
                if (_ticket[i] != null)
                {
                    Console.WriteLine($"Ticket #{i+1} {_ticket[i]}");
                }
            }
        }

            public void OpenCinema()
            {
                projector.start();  
            }
        public void CloseCinema()
        {
            projector.stop();
        }

    }
}
