using Domain.Core;
using Domain.ValueObjects;
using System.Drawing;
using System.Runtime.CompilerServices;
using Color = Domain.ValueObjects.Color;

namespace Domain.Entities
{
    internal class Board : Entity<Guid>
    {
        const string X_CHARACTERS = "ABCDEFGH";

        Field[,] Fields;


        public Board(Guid id) : base(id)
        {
            SetFields();
            SetPieces();
        }

        private void SetPieces()
        {
            SetWhitePawns();
            SetBlackPawns();
        }

        private void SetFields()
        {
            Fields = new Field[7, 7];
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    var color = DetermineFieldColor(x, y);
                    Fields[x, y] = new Field(new Position(X_CHARACTERS[x].ToString(), y), color);

                }
            }
        }

        private void SetWhitePawns()
        {
            for(int x = 0;x < 7; x++)
            {
                Fields[x, 1].SetPiece(new Pawn(Color.White));
            }
        }

        private void SetBlackPawns()
        {
            for (int x = 0; x < 7; x++)
            {
                Fields[x, 6].SetPiece(new Pawn(Color.Black));
            }
        }

        private Color DetermineFieldColor(int x, int y)
        {
            var evenX = x % 2;
            var evenY = y % 2;
            if (evenX == 0 && evenY == 0 || evenX == 1 && evenY == 0)
            {
                return Color.Black;
            } 
            else
            {
                return Color.White;
            }
        }
    }
}
