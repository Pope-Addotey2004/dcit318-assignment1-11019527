namespace Ticketing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerTicket ticket = new CustomerTicket();

            Console.WriteLine("Customer should please enter His/Her Age: ");
            int Age = int.Parse(Console.ReadLine());

            if (Age < 0)
            {
                Console.WriteLine("Age cannot be negative. Please enter a valid age.");
                int Age1 = int.Parse(Console.ReadLine());
                ticket.TicketingScheme(ticket.TicketPrice, Age1);
            }

            ticket.TicketingScheme(ticket.TicketPrice, Age);
            //Console.WriteLine(ticket.NewPrice.ToString() + "cedis");

        }
    }
}
