namespace program
{
    public class customer
    {
        public string customerId { get; set; }
        public string customerCity { get; set; }

        public customer(string id, string city)
        {
            customerId = id;
            customerCity = city;

        }

        public override string ToString()
        {
            return $"Customer id {customerId} City:{customerCity}";
                }


    }
}