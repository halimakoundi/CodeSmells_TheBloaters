namespace LongParameterLists
{
    public class Address
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Postcode { get; set; }

        public string GetAddressSummary()
        {
            return City + ", " + Postcode + ", " + Country;
        }
    }
}