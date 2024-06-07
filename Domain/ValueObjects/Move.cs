using Domain.Core;

namespace Domain.ValueObjects
{
    public class Move : ValueObject
    {
        public Field StartField { get; }
        public Field EndField { get; }

        public Move(Field startField, Field endField)
        {
            StartField = startField;
            EndField = endField;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return StartField;
            yield return EndField;
        }
    }
}
