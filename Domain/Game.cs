using Domain.Core;
using Domain.Entities;
using Domain.Events;
using Domain.ValueObjects;

namespace Domain
{
    public class Game : AggregateRoot<Guid>
    {
        private Player player1;
        private Player player2;
        private Board board;

        public Game(Guid id): base(id)
        {
        }

        public void CreateGame(Player player)
        {
            var @event = new GameCreatedEvent(player);
            RaiseEvent(@event);
        }

        private void When(GameCreatedEvent domainEvent)
        {
            player1 = domainEvent.player;
        }

        public void JoinGame(Player player)
        {
            var @event = new GameJoinedEvent(player);
            RaiseEvent(@event);
        }

        private void When(GameJoinedEvent domainEvent)
        {
            player2 = domainEvent.player;
            AssignColors();
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
            StartGame();
        }

        public void StartGame()
        {
            var @event = new GameStartedEvent();
            RaiseEvent(@event);
        }

        private void When(GameStartedEvent domainEvent)
        {
            board = new Board(Id);
        }

        protected override void When(dynamic domainEvent)
        {
            When(domainEvent);
        }
    }
}
