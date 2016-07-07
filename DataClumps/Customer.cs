namespace DataClumps
{
    public class Customer
    {
        private readonly Address _address;

        public Customer(string title, string firstName, string lastName, string house, string street, string city, string postCode, string country)
        {
            _address = new Address(house, street, city, postCode, country);
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