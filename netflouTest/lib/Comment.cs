using System;

namespace Netflou.Models
{
    public class Comment {
        
        private string userName;

        public string UserName {
            get{return userName;}
            set{userName = value;}
        }

        private string text;

        public string Text {
            get{return text;}
            set{ text = value;}
        }
    }
}
