namespace WebTicket.Models.BaseModels
{
    using System.ComponentModel.DataAnnotations;
    using WebTicket.Models.Contracts;
    public abstract class Production : IProduction
    {
        public Production()
        {
            this.Cast = new HashSet<IEntertainer>();    
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public ICollection<IEntertainer> Cast { get; set; }
    }
}
