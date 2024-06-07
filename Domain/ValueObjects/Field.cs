using Domain.Core;

namespace Domain.ValueObjects
{
    public class Field : ValueObject
    {
        public Position Position { get; }
        public Color Color { get; }
        public Piece? Piece { get; private set; }

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

        public void SetPiece(Piece piece)
        {
            Piece = piece;
        }
    }
}
