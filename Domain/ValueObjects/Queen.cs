namespace Domain.ValueObjects
{
    internal class Queen : Piece
    {
        public Queen(Color color) : base(color, MovementType.Queen, 7)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
