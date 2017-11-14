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
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        private string category;
        public string Category {
            get{return category;}
            set{category = value;}
        }
        private string img;
        public string Img
        {
            get { return img; }
            set { img = value; }
        }

        
    }
}
