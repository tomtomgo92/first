using System;
using System.Collections;

namespace lib
{
    public class Library
    {
        public Library()
        {

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
                Season = 8
               
                
                });
            mediaList.Add(new Film{
                Title = "Interstellar",
                Synopsis = @"
                Interstellar, ou Interstellaire au Québec, est un film 
                de science-fiction britannico-américain produit, 
                écrit et réalisé par Christopher Nolan, sorti le 5 novembre 2014.
                ",
                Img = "http://t1.gstatic.com/images?q=tbn:ANd9GcSIVryzUKVaqs-5yb0-uHykg7Ob4rUWFl-Ojl28OvBExh8Xc8GT",
                Director = "Christopher Nolan"
            });
        }
    }
}
