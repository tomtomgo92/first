using System;

namespace lib
{
    public class Serie : Media {
        private int seasons;
        public int Season {
            get{return seasons;}
            set{ seasons = value;}
        } 
    }
}