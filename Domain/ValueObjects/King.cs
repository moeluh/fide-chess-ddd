namespace Domain.ValueObjects
{
    public class King : Piece
    {
        public King(Color color) : base(color, MovementType.HorizontalVertical, 1)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
