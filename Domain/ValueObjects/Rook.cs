namespace Domain.ValueObjects
{
    public class Rook : Piece
    {
        public Rook(Color color): base(color, MovementType.HorizontalVertical, 8)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
