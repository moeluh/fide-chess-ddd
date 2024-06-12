using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Events
{
    public  class TurnStartedEvent : DomainEvent
    {
        public Player Player { get; private set; }

        public TurnStartedEvent(Player player)
        {
            Player = player;
        }
    }
}
