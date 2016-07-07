namespace DataClumps.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void CustomerAddressSummaryIncludesHouseStreetCityPostCodeAndCountry()
        {
            var customer = new Customer("Dr", "Joseph", "Bloggs", new Address("43", "Rankin Road", "London", "SW23 9YY", "United Kingdom"));

            Assert.AreEqual("43, Rankin Road, London, SW23 9YY, United Kingdom", customer.AddressSummary);
        }
    }
}