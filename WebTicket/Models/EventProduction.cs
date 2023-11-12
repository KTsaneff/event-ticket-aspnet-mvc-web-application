namespace WebTicket.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using WebTicket.Models.Contracts;
    public class EventProduction
    {
        [Required]
        public int ProductionId { get; set; }
        [ForeignKey(nameof(ProductionId))]
        public IProduction Production { get; set; } = null!;

        [Required]
        public int EventId { get; set; }
        [ForeignKey(nameof(EventId))]
        public IEvent Event { get; set; } = null!;
    }
}
