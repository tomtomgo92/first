using System;
using System.Collections;
using Microsoft.Data.Sqlite;

namespace lib
{
    public class Library
    {
        public Library()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder
            {
                DataSource = "myDb.db"
            };

            using (var connection = new SqliteConnection())
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
                    };
                };

            };
        }
    }
}