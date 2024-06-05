using Domain.Core;


namespace Domain.ValueObjects
{
    public class Player : ValueObject
    {
        public Color color { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return color;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }
    }
}
