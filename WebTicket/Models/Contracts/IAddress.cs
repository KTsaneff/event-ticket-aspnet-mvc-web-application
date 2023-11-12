namespace WebTicket.Models.Contracts
{
    public interface IAddress
    {
        int Id { get; set; }

        string Number { get; set; }

        string StreetOrLocation { get; set; }

        string City { get; set; }

        string StateOrProvince { get; set; }

        string PostalCode { get; set; }

        string Country { get; set; }
    }
}
