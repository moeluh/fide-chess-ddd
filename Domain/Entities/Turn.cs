﻿using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Turn : Entity<Guid>
    {
        public Player Player { get; private set; }

        public Turn(Guid id, Player player) : base(id)
        {
            Player = player;
        }
    }
}
