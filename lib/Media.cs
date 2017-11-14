using System;

namespace lib
{
    public abstract class Media
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

        
    }
}
