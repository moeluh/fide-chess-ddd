using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Events
{
    public class GameCreatedEvent : DomainEvent
    {
        public Player Player { get; }

        public GameCreatedEvent(Player player)
        {
            Player = player;
        }
    }
}
