using Domain.Core;
using Domain.Entities;
using Domain.Events;
using Domain.ValueObjects;

namespace Domain
{
    public class Game : AggregateRoot<Guid>
    {
        private Player Player1;
        private Player Player2;
        private Board Board;

        public Game(Guid id) : base(id)
        {
        }

        public void CreateGame(Player player)
        {
            var @event = new GameCreatedEvent(player);
            RaiseEvent(@event);
        }

        private void When(GameCreatedEvent domainEvent)
        {
            Player1 = domainEvent.Player;
        }

        public void JoinGame(Player player)
        {
            var @event = new GameJoinedEvent(player);
            RaiseEvent(@event);
        }

        private void When(GameJoinedEvent domainEvent)
        {
            Player2 = domainEvent.Player;
            AssignColors();
        }

        public void AssignColors()
        {
            var @event = new ColorAssignedEvent(Color.White, Color.Black);
            RaiseEvent(@event);
        }

        private void When(ColorAssignedEvent domainEvent)
        {
            Player1.SetColor(domainEvent.Player1Color);
            Player2.SetColor(domainEvent.Player2Color);
            StartGame();
        }

        public void StartGame()
        {
            var @event = new GameStartedEvent();
            RaiseEvent(@event);
        }

        private void When(GameStartedEvent domainEvent)
        {
            Board = new Board(Id);
        }

        protected override void When(dynamic domainEvent)
        {
            When(domainEvent);
        }
    }
}
