namespace WebTicket.Models.Contracts
{
    public interface IEventVenue
    {
        int Id { get; set; }

        string Name { get; set; }

        IAddress Address { get; set; }

        int Capacity {  get; set; }

        ICollection<IEvent> CurrentEvents { get; set; }

        ICollection<IEvent> UpcomingEvents { get; set; }
    }
}
