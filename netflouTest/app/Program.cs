using System;
using Netflou.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace app
{
    class Program
    {
        public class MovieContext : DbContext
        {
            public DbSet<Film> Film { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=db.db");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("coucou");

            var db = new MovieContext();
            var film = new Film{
                Id = 89,
                Title = "test"
            };
           
            try
            {
				Console.WriteLine("coucou2");
                db.Film.Add(film);
                Console.WriteLine("coucou3");
                db.SaveChanges();
                Console.WriteLine("coucou4");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //foreach (var list in db.Film)
            //{
            //    Console.WriteLine(list.Title);
            //}

            }
        }

}

