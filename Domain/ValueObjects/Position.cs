using Domain.Core;

namespace Domain.ValueObjects
{
    public class Position : ValueObject
    {
        public string X { get; private set; }
        public int Y { get; private set; }

        public Position(string x, int y)
        {
            X = x;
            Y = y;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return X;
            yield return Y;
        }
    }
}
