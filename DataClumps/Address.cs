namespace DataClumps
{
    public class Address
    {
        public Address(string house, string street, string city, string postCode, string country)
        {
            House = house;
            Street = street;
            City = city;
            PostCode = postCode;
            Country = country;
        }

        public string House { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}