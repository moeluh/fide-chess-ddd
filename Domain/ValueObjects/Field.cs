using Domain.Core;

namespace Domain.ValueObjects
{
    internal class Field : ValueObject
    {
        Position position { get; }
        Color color { get; }

        public Field(Position position, Color color)
        {
            this.position = position;
            this.color = color;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return position;
            yield return color;
        }
    }
}
