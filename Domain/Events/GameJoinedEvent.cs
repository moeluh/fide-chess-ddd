using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Events
{
    public class GameJoinedEvent : DomainEvent
    {
        public Player Player { get; }

        public GameJoinedEvent(Player player)
        {
            Player = player;
        }
    }
}
