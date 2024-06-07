namespace Domain.ValueObjects
{
    public class Rook : Piece
    {
        public Rook(Color color) : base(color, MovementType.HorizontalVertical, 7)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
