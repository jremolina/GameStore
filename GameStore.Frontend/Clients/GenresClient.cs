using System;
using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GenresClient
{
    private readonly Genre[] genres = [
        new (){
            Id = 1,
           Name = "fighting"
        },
         new (){
            Id = 2,
           Name = "Racing"
        },
         new (){
            Id = 3,
           Name = "RPM"
        },


    ];

    public Genre[] GetGenres()
    {
        return genres.ToArray();
    }

}
