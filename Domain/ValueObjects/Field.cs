using Domain.Core;

namespace Domain.ValueObjects
{
    public class Field : ValueObject
    {
        Position Position { get; }
        Color Color { get; }

        public Field(Position position, Color color)
        {
            Position = position;
            Color = color;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Position;
            yield return Color;
        }
    }
}
