namespace Domain.ValueObjects
{
    internal class Pawn : Piece
    {
        public Pawn(Color color) : base(color, MovementType.Pawn, 2)
        {
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
