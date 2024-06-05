using Domain.Core;

namespace Domain.Entities
{
    internal class Turn : Entity<Guid>
    {
        public Turn(Guid id) : base(id)
        {
        }
    }
}
