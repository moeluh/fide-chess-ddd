﻿using Domain.Core;
using Domain.ValueObjects;

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
            Color color = Color.Black;
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    // TODO Fix Color
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


    }
}
