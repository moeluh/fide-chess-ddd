using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Entities
{
    internal class Board : Entity<Guid>
    {
        const string X_CHARACTERS = "ABCDEFGH";

        Field[,] fields;


        public Board(Guid id) : base(id)
        {
            setFields();
            setPieces();
        }

        private void setPieces()
        {
            
        }

        private void setFields()
        {
            fields = new Field[7, 7];
            Color color = Color.Black;
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    // TODO Fix Color
                    fields[x, y] = new Field(new Position(X_CHARACTERS[x].ToString(), y), color);

                }
            }
        }
    }
}
