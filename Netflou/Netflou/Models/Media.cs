using System;

namespace Netflou.Models
{
    public class Media
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

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
