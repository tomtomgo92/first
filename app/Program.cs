using System;
using lib;
using Microsoft.Data.Sqlite;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coucou");
            var serie = new Serie();

            var connectionStringBuilder = new SqliteConnectionStringBuilder
            {
                DataSource = "myDb.db"
            };


            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {

                connection.Open();

                var selectCommand = connection.CreateCommand();

                selectCommand.CommandText = "SELECT * FROM library";


                using (var reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var message = $"{reader["ID"]} - {reader["Title"]}";
                        Console.WriteLine(message);
                    }
                }

            }
        }
    }
}
