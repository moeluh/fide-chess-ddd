using Domain.Core;
using Domain.Entities;
using Domain.Events;
using Domain.ValueObjects;

namespace Domain
{
    public class Game : AggregateRoot<Guid>
    {
        Player player1 = new Player();
        Player player2 = new Player();
        Board board { get; }

        public Game(Guid id): base(id)
        {
            board = new Board(id);
        }

        public void AssignColors()
        {
            var @event = new ColorAssignedEvent(Color.White, Color.Black);
            RaiseEvent(@event);
        }

        private void When(ColorAssignedEvent domainEvent)
        {
            player1.SetColor(domainEvent.Player1Color);
            player2.SetColor(domainEvent.Player2Color);
        }

        protected override void When(DomainEvent domainEvent)
        {
            switch (domainEvent)
            {
                case ColorAssignedEvent _event:
                    When(_event);
                    break;
            }
        }
    }
}
