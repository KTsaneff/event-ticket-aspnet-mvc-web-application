namespace WebTicket.Models.BaseModels
{
    using System.ComponentModel.DataAnnotations;
    using WebTicket.Models.Contracts;
    public abstract class Production : IProduction
    {
        public Production()
        {
            this.Cast = new HashSet<IEntertainer>();
            this.EventsProductions = new HashSet<EventProduction>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public Director Director { get; set; } = null!;
        public Producer? Producer { get; set; }
        public ICollection<IEntertainer> Cast { get; set; }

        public ICollection<EventProduction> EventsProductions { get; set; }
    }
}
