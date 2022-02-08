using System;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //stuff 
        }

        public DbSet<MovieResponses> Responses { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MovieResponses>().HasData(

                new MovieResponses
                {
                    MovieId = 1,
                    Category = "Action/Adventure",
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },

                new MovieResponses
                {
                    MovieId = 2,
                    Category = "Comedy",
                    Title = "Maverick",
                    Year = 1994,
                    Director = "Richard Donner",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },
                
                new MovieResponses
                {
                    MovieId = 3,
                    Category = "Comedy",
                    Title = "Mrs. Doubtfire",
                    Year = 1993,
                    Director = "Chris Columbus",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },


                new MovieResponses
                {
                    MovieId = 4,
                    Category = "Action/Adventure",
                    Title = "Ladyhawke",
                    Year = 1985,
                    Director = "Richard Donner",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Most Quotable",
                }
            );
        }
    }
}