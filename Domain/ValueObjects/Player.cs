using Domain.Core;


namespace Domain.ValueObjects
{
    public class Player : ValueObject
    {
        public Color Color { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Color;
        }

        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}
