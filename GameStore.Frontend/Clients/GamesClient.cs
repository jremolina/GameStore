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

    private readonly Genre[] genres = new GenresClient().GetGenres();

    public GameSummary[] GetGames()
    {
        return games.ToArray();
    }

    public void addGame(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

        var gameSummary = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
        games.Add(gameSummary);

    }

}
