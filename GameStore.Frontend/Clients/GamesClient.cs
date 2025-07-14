using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games =
    [
        new ()
        {
        Id = 1,
        Name = "Street Figter",
        Genre = "fighting",
        Price = 59.99m,
        ReleaseDate = new DateOnly(1992, 7, 15)
        },
        new ()
        {
        Id = 2,
        Name = "Super Mario Kart",
        Genre = "Racing",
        Price = 49.99m,
        ReleaseDate = new DateOnly(1994, 6, 1)
        },
        new ()
        {
        Id = 3,
        Name = "Mortal Kombat",
        Genre = "Fighting",
        Price = 39.99m,
        ReleaseDate = new DateOnly(1993, 3, 1)
        }
    ];

    public GameSummary[] GetGames()
    {
        return games.ToArray();
    }

}
