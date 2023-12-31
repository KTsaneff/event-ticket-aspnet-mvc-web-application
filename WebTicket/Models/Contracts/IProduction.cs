﻿namespace WebTicket.Models.Contracts
{
    public interface IProduction
    {
        int Id { get; set; }

        string Name { get; set; }

        Director Director { get; set; }

        Producer Producer { get; set; }

        ICollection<IEntertainer> Cast {  get; set; }

        ICollection<EventProduction> EventsProductions { get; set; }
    }
}
