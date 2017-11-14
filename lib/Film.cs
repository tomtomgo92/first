using System;

namespace lib
{
    public class Film
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string synopsis;
        public string Synopsis
        {
            get { return synopsis; }
            set { synopsis = value; }
        }
        private int rate;
        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        // private Category category;
        private string img;
        public string Img
        {
            get { return img; }
            set { img = value; }
        }

        public Film(string title, string synopsis, int rate, /* Category category,  */string img)
        {
            this.title = title;
            this.synopsis = synopsis;
            this.rate = rate;
            // this.category = category;
            this.img = img;
        }
    }
}
