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

       

            var mediaList = new ArrayList();

            mediaList.Add(new Serie{
                Title = "Desperate",
                Synopsis = @"
                Desperate Housewives ou Beautés désespérées est un feuilleton 
                télévisé américain en 180 épisodes de 42 minutes 
                créé par Marc Cherry et diffusé entre le 3 octobre 2004 
                et le 13 mai 2012 sur le réseau ABC et en simultané 
                au Canada sur le réseau CTV
                ",
                Img = "https://str01-m.dpstream.media/s/11/desperate-housewives-55ffaf24e182e-1472989029.jpg",
                Season = 8,
                Category = "Drama"
                });
            mediaList.Add(new Serie{
                Title = "Stanger Things",
                Synopsis = @"
                A Hawkins, en 1983 dans l'Indiana. Lorsque Will Byers disparaît de son domicile, ses amis se lancent dans une recherche semée d’embûches pour le retrouver.
                Dans leur quête de réponses, les garçons rencontrent une étrange jeune fille en fuite.
                Les garçons se lient d'amitié avec la demoiselle tatouée du chiffre '11' sur son poignet et au crâne rasé et découvrent petit à petit les détails sur son inquiétante situation. Elle est peut-être la clé de tous les mystères qui se cachent dans cette petite ville en apparence tranquille…
                ",
                Img = "http://fr.web.img1.acsta.net/r_640_600/b_1_d6d6d6/pictures/17/10/23/14/24/5968627.jpg",
                Season = 2,
                Category = "Science Fiction"  
                });
            mediaList.Add(new Film{
                Title = "Interstellar",
                Synopsis = @"
                Interstellar, ou Interstellaire au Québec, est un film 
                de science-fiction britannico-américain produit, 
                écrit et réalisé par Christopher Nolan, sorti le 5 novembre 2014.
                ",
                Img = "http://t1.gstatic.com/images?q=tbn:ANd9GcSIVryzUKVaqs-5yb0-uHykg7Ob4rUWFl-Ojl28OvBExh8Xc8GT",
                Director = "Christopher Nolan",
                Category = "Science Fiction" 
            });
        }
    }
}
