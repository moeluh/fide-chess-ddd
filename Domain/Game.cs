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
        private Turn? currentTurn;

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
            var random = new Random();
            var player1Color = (Color)random.Next(2);
            var player2Color = player1Color == Color.White ? Color.Black : Color.White;
            var @event = new ColorAssignedEvent(player1Color, player2Color);
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
            StartTurn();
        }

        public void StartTurn()
        {
            TurnStartedEvent @event;
            if (currentTurn == null)
            {
                var startPlayer = Player1.Color == Color.White ? Player1 : Player2;
                @event = new TurnStartedEvent(startPlayer);
            }
            else
            {
                var newTurnPlayer = currentTurn.Player.Equals(Player1) ? Player2 : Player1;
                @event = new TurnStartedEvent(newTurnPlayer);
            }
            RaiseEvent(@event);
        }

        private void When(TurnStartedEvent domainEvent)
        {
            currentTurn = new Turn(Guid.NewGuid(), domainEvent.Player);
        }

        protected override void When(dynamic domainEvent)
        {
            When(domainEvent);
        }
    }
}
