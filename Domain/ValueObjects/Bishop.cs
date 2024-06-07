namespace Domain.ValueObjects
{
    internal class Bishop : Piece
    {
        public Bishop(Color color) : base(color, MovementType.Diagonal, 7)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
