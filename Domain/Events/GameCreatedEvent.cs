using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Events
{
    public class GameCreatedEvent : DomainEvent
    {
        public Player player { get; }

        public GameCreatedEvent(Player player)
        {
            this.player = player;
        }
    }
}
