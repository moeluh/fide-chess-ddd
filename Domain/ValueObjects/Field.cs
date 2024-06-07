using Domain.Core;

namespace Domain.ValueObjects
{
    internal class Field : ValueObject
    {
        public Position position { get; }
        public Color color { get; }
        public Piece? piece { get; private set; }

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

        public void SetPiece(Piece piece)
        {
            this.piece = piece;
        }
    }
}
