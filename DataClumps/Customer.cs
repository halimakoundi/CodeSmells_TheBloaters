namespace DataClumps
{
    public class Customer
    {
        private readonly Address _address;

        public Customer(string title, string firstName, string lastName, Address address)
        {
            _address = address;
            FirstName = firstName;
            LastName = lastName;
            Title = title;
        }

        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string AddressSummary
        {
            get
            {
                return _address.Summary();
            }
        }
    }
}