// <auto-generated />
using JoelHilton.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JoelHilton.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220208062229_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("JoelHilton.Models.MovieResponses", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            Category = "Action/Adventure",
                            Director = "Joss Whedon",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Avengers, The",
                            Year = 2012
                        },
                        new
                        {
                            MovieId = 2,
                            Category = "Comedy",
                            Director = "Richard Donner",
                            Edited = false,
                            Rating = "PG",
                            Title = "Maverick",
                            Year = 1994
                        },
                        new
                        {
                            MovieId = 3,
                            Category = "Comedy",
                            Director = "Chris Columbus",
                            Edited = false,
                            Rating = "PG-13",
                            Title = "Mrs. Doubtfire",
                            Year = 1993
                        },
                        new
                        {
                            MovieId = 4,
                            Category = "Action/Adventure",
                            Director = "Richard Donner",
                            Edited = false,
                            Notes = "Most Quotable",
                            Rating = "PG-13",
                            Title = "Ladyhawke",
                            Year = 1985
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
