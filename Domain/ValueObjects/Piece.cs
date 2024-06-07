using Domain.Core;

namespace Domain.ValueObjects
{
    public abstract class Piece : ValueObject { 
        public Color Color { get; }
        public string MovementType { get; }

        public Piece(Color color, string movementType)
        {
            Color = color;
            MovementType = movementType;
        }
    }
}
