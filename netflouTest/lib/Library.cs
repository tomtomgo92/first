using System;
using System.Collections;
using Microsoft.Data.Sqlite;

namespace Netflou.Models
{
    public class Netflou.Modelsrary
    {
        public Netflou.Modelsrary()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder
            {
                DataSource = "myDb.db"
            };

            using (var connection = new SqliteConnection())
            {

                connection.Open();

                var selectCommand = connection.CreateCommand();

                selectCommand.CommandText = "SELECT * FROM Netflou.Modelsrary";


                using (var reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var message = $"{reader["ID"]} - {reader["Title"]}";
                        Console.WriteLine(message);
                    };
                };

            };
        }
    }
}