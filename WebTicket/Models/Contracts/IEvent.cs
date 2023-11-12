namespace WebTicket.Models.Contracts
{
    public interface IEvent
    {
        int Id { get; set; }

        IProduction Production { get; set; }

        DateTime StartDateAndTime { get; set; }

        ICollection<IEntertainer> Cast {  get; set; }

        ICollection<EventProduction> EventsProductions { get; set; }
    }
}
