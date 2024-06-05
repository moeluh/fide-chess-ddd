using Domain.Core;

namespace Domain.ValueObjects
{
    public class Position : ValueObject
    {
        public string x { get; private set; }
        public int y { get; private set; }

        public Position(string x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return x;
            yield return y;
        }
    }
}
