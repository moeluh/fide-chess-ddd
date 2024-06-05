using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Events
{
    public class ColorAssignedEvent : DomainEvent
    {
        public Color Player1Color { get; }
        public Color Player2Color { get; }

        public ColorAssignedEvent(Color player1Color, Color player2Color)
        {
            Player1Color = player1Color;
            Player2Color = player2Color;
        }
    }
}
