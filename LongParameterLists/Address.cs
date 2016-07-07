namespace LongParameterLists
{
    public class Address
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Postcode { get; set; }

        public static string GetAddressSummary(Address address)
        {
            return address.City + ", " + address.Postcode + ", " + address.Country;
        }
    }
}