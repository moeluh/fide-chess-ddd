namespace Domain.ValueObjects
{
    internal class Knight : Piece
    {
        public Knight(Color color) : base(color, MovementType.Leap, 3)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
