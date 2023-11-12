namespace WebTicket.Models
{
    using System.ComponentModel.DataAnnotations;
    using WebTicket.Models.Contracts;
    public class Address : IAddress
    {
        [Key]
        public int Id { get; set; }

        public string? Number { get; set; }

        public string StreetOrLocation { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required]
        public string StateOrProvince { get; set; } = null!;

        [Required]
        public string PostalCode { get; set; } = null!;

        [Required]
        public string Country { get; set; } = null!;
    }
}
