namespace EFCore_CodeFirst.Models.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public int StreetNo { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public Employee Employee { get; set; }
    }
}
