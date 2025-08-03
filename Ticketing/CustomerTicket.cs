using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing
{
    
    internal class CustomerTicket
    {
        public int TicketPrice { get; set; } = 10;
        public int NewPrice { get; set; }

        public int CustomerAge { get; set; }

        public  int TicketingScheme(int TicketPrice, int CustomerAge)
        {
            if (CustomerAge>=65 || CustomerAge<=12)
            {
                NewPrice = TicketPrice - 3;
                
                Console.WriteLine(NewPrice.ToString() + "cedis");
            }
            else
            {
                 NewPrice = TicketPrice;
                Console.WriteLine(NewPrice.ToString() + "cedis");
            }

            return NewPrice;
        }

        
    }
}
