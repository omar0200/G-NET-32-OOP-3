namespace G_NET_32_OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1

            #region Question 1
            /*
             A) composition
             b) association
             c)aggregation 
             d)inheritance  
             e) dependency
             */
            #endregion

            #region Question 2
            /*
             a) yes it will be accessible ,no
             b) * private is only accessible within the class
                * protected is accessible within the class and its derived classes
                * internal is accessible within the same assembly
                * public is accessible from anywhere
             c) it means it cant be drived , and method cant be override
            d) yes we can , because seal prevents inheritance but not object creation
            */
            #endregion
            #endregion


            #region part 2 

           CinemaName c1 = new CinemaName();
            c1.OpenCinema();
            c1.addticket(new IMAXTicket("Avengers", 100,true));
            c1.addticket(new StandardTicket("Spiderman", 80,"3a"));
            c1.addticket(new VIPTicket("Batman", 90, false));
            c1.printalltickets();
            c1.CloseCinema();   
            #endregion
        }
    }
}
