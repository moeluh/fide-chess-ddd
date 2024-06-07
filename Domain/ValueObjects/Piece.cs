using Domain.Core;

namespace Domain.ValueObjects
{
    public abstract class Piece : ValueObject
    {
        public Color Color { get; }
        public MovementType MovementType { get; }
        public int MovementRange { get; }

        protected Piece(Color color, MovementType movementType, int movementRange)
        {
            Color = color;
            MovementType = movementType;
            MovementRange = movementRange;
        }
    }
}
