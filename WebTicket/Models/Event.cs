namespace WebTicket.Models
{
    using System.ComponentModel.DataAnnotations;
    using WebTicket.Models.Contracts;
    public class Event : IEvent
    {
        public Event()
        {
            Cast = new HashSet<IEntertainer>();
            EventsProductions = new HashSet<EventProduction>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public IProduction Production { get; set; } = null!;

        [Required]
        public DateTime StartDateAndTime { get; set; }

        public ICollection<IEntertainer> Cast { get; set; }

        public ICollection<EventProduction> EventsProductions { get; set; }
    }
}
