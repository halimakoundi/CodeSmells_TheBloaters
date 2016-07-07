namespace LongParameterLists
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public Address Address { get; set; }

        public string Summary
        {
            get
            {
                return buildCustomerSummary(Address.City,
                                            Address.Postcode,
                                            Address.Country);
            }
        }

        private string buildCustomerSummary(string customerCity, string customerPostCode, string customerCountry)
        {
            return Title + " " + FirstName + " " + LastName + ", " + customerCity + ", "
                   + customerPostCode + ", " + customerCountry;
        }
    }
}