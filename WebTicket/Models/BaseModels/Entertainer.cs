namespace WebTicket.Models.BaseModels
{
    using System.ComponentModel.DataAnnotations;
    using WebTicket.Models.Contracts;

    public abstract class Entertainer : IEntertainer
    {
        public Entertainer()
        {
            Productions = new HashSet<IProduction>();
        }

        [Key]
        public int Id { get; set; }

        public string ProfileImageUrl { get; set; } = null!;

        [Required]
        public string FullName { get; set; } = null!;

        public ICollection<IProduction> Productions { get; set; }

        public string? Biography { get; set; }
    }
}
