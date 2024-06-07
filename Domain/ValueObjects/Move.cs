using Domain.Core;

namespace Domain.ValueObjects
{
    public class Move : ValueObject
    {
        public Position StartPosition { get; }
        public Position EndPosition { get; }

        public Move(Position startPosition, Position endPosition)
        {
            StartPosition = startPosition;
            EndPosition = endPosition;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return StartPosition;
            yield return EndPosition;
        }
    }
}
