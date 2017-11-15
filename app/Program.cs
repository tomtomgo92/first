using System;
using lib;
using Microsoft.Data.Sqlie;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coucou");

            public DbSet<film> films { get; set; }
            public DbSet<serie> series { get; set; }
            
            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=myBd.db");
            }

        using (var db = new MovieContext())
            {
                db.films.Add(new Film = (title ="test", synopsis ="test sy", img= "test url", rate=2, states=0, category="cat", director="direct"));
                var count = db.SaveChanges();
                 db.series.Add(new Serie = (title ="test ser", synopsis ="test sy ser", img= "test url ser", rate=2, states=1, category="czt", saison=2));
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Film)
                {
                    Console.WriteLine(" - {0}", film.id);
                }
            }

              

        }
    }


    public class MovieContext
    {
        public DbSet<film> films { get; set; }
            public DbSet<serie> series { get; set; }

    }
    public class Film
    {  
        //int id { get; set; }
        string title { get; set; }
        string synopsis { get; set; }
        string img { get; set; }
        int rate { get; set; }
        int states { get; set; } //boolean
        string category { get; set; }
        string director { get; set; }
    }

        public class Serie
    {
        //int id { get; set; }
        string title { get; set; }
        string synopsis { get; set; }
        string img { get; set; }
        int rate { get; set; }
        int states { get; set; } //boolean
        string category { get; set; }
        int saison { get; set; }
    }
}
