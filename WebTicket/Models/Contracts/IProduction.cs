namespace WebTicket.Models.Contracts
{
    public interface IProduction
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<IEntertainer> Cast {  get; set; }
    }
}
