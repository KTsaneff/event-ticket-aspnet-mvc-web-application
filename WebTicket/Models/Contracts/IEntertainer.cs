using System.ComponentModel.DataAnnotations;

namespace WebTicket.Models.Contracts
{
    public interface IEntertainer
    {
        int Id { get; set; }

        string ProfileImageUrl { get; set; }

        string FullName { get; set; }

        ICollection<IEvent> Productions { get; set; }

        string Biography { get; set; }
    }
}
