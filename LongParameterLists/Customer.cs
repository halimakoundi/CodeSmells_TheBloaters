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
                return BuildCustomerSummary(Address);
            }
        }

        private string BuildCustomerSummary(Address address)
        {
            var customerSummary = Title + " " + FirstName + " " + LastName + ", ";
            customerSummary += GetAddressSummary(address);
            return customerSummary;
        }

        private static string GetAddressSummary(Address address)
        {
            return address.City + ", " + address.Postcode + ", " + address.Country;
        }
    }
}