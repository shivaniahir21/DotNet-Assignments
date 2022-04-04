/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/


namespace program
{
    class test
    {
        public static void Main()
        {
            List<customer> customer = new List<customer>();
            customer.Add(new customer("A01", "KUTCHH"));
            customer.Add(new customer("A02", "RAJKOT"));
            customer.Add(new customer("A03", "DUBAI"));
            customer.Add(new customer("A04", "USA"));
            customer.Add(new customer("A05", "RASIA"));
            customer.Add(new customer("A06", "LONDON"));
            customer.Add(new customer("A07", "JAPAN"));
            customer.Add(new customer("A08", "NEW YORK"));

            var custSelectQuery = from cust in customer
                                  select cust;

            Console.WriteLine("customer list::");
            foreach (var cust in custSelectQuery)
            {
                Console.WriteLine(cust);

            }

            Console.WriteLine("\nCustomer in LONDON City::");
            var custLondonQuery =
            from cust in customer
            where cust.customerCity == "LONDON"
            select cust;
            foreach (var cust in custLondonQuery)
            {
                Console.WriteLine(cust);

            }

            Console.WriteLine("\nTotal customers::");
            int totalcust = custSelectQuery.Count();
            Console.WriteLine(totalcust);

            Console.WriteLine("\ncustomer ID start with A::");
            var custAQuery = from cust in customer
                             where cust.customerId.StartsWith("A")
                             select cust;

            foreach (var cust in custAQuery)
            {
                Console.WriteLine(cust);
            }




        }
    }
}