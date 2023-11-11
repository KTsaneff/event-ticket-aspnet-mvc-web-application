using System.ComponentModel.DataAnnotations;

namespace WebTicket.Models.Contracts
{
    public interface IEntertainer
    {
        public int Id { get; set; }

        public string ProfileImageUrl { get; set; }

        public string FullName { get; set; }

        public ICollection<IProduction> Productions { get; set; }

        public string Biography { get; set; }
    }
}
