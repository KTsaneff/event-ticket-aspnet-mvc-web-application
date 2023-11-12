namespace WebTicket.Models.BaseModels
{
    using System.ComponentModel.DataAnnotations;
    using WebTicket.Models.Contracts;
    public abstract class EventVenue : IEventVenue
    {
        public EventVenue()
        {
            this.CurrentEvents = new HashSet<IEvent>();
            this.UpcomingEvents = new HashSet<IEvent>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public IAddress Address { get; set; } = null!;

        [Required]
        public int Capacity { get; set; }

        public ICollection<IEvent> CurrentEvents { get; set; }

        public ICollection<IEvent> UpcomingEvents { get; set; }
    }
}
