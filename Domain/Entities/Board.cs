using Domain.Core;

namespace Domain.Entities
{
    internal class Board : Entity<Guid>
    {
        public Board(Guid id) : base(id)
        {
        }
    }
}
