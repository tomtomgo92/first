using System;

namespace lib {
    public class Film : Media{
        private string director;
        public string Director {
            get{return director;}
            set{director = value;}
        }
    }
}