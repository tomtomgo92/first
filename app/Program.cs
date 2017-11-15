using System;
using lib;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coucou");

            using (var db = new MovieContext())
            {
                var theFilms = new Film
                {
                    Title = "test",
                    Synopsis = "test sy",
                    Img = "test url",
                    Rate = 2,
                    Status = true,
                    Category = "cat",
                    Director = "director"
                };

                db.Film.Add(theFilms);


                Console.WriteLine("{0} records saved to database");

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");

                Console.WriteLine(db.SaveChanges());
                db.SaveChanges();

            }

              

        }

    }



    public class MovieContext : DbContext
    {
        public DbSet<Film> Film { get; set; }
        public DbSet<Serie> Serie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Data Source=myDb.db");
        }
    }

}

