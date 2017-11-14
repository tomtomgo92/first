using System;

namespace lib
{
    public class Comment {
        private string userName;
        public string UserName {
            get{return username;}
            set{userName = value;}
        }
        private string text;
        public string Text {
            get{return text;}
            set{ text = value;}
        }
    }
}