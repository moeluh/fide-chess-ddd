// See https://aka.ms/new-console-template for more information
using Domain;

Console.WriteLine("Hello, World!");


Game game = new Game(Guid.NewGuid());
game.CreateGame(new Domain.ValueObjects.Player());
game.JoinGame(new Domain.ValueObjects.Player());
