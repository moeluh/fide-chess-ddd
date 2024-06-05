using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events
{
    internal class GameJoinedEvent
    {
        Player creator;
        Player joiner;
    }
}
