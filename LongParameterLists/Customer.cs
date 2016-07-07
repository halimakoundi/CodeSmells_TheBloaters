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
                return buildCustomerSummary(Address);
            }
        }

        private string buildCustomerSummary(Address address)
        {
            var customerSummary = Title + " " + FirstName + " " + LastName + ", ";
            customerSummary += address.City + ", " + address.Postcode + ", " + address.Country;
            return customerSummary;
        }
    }
}