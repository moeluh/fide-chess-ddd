﻿using Domain.Core;
using Domain.ValueObjects;

namespace Domain.Events
{
    public class GameJoinedEvent : DomainEvent
    {
        public Player player { get; }

        public GameJoinedEvent(Player player)
        {
            this.player = player;
        }
    }
}
