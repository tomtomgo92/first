﻿using System;
namespace tvshow
{
    public class Film
    {
        private string title;
        private string synopsis;
        private int rate;
        private string img;
        public Commentaire[] comList;
        // Categorie;

        public Film(string showTitle, string showSynopsis, int showRate, string showImg)
        {
            title = showTitle;
            synopsis = showSynopsis;
            rate = showRate;
            img = showImg;
        }

        public string getTitle()
        {
            return this.title;
        }
        public string getSynopsis()
        {
            return this.synopsis;
        }
        public int getRate()
        {
            return this.rate;
        }
        public string getImg()
        {
            return this.img;
        }
    }
}
