using System.Collections.Generic;
using Netflou.Models;
using lib;

namespace Netflou.Controllers
{


    public class MediaList
    {
        public MediaList()
        {
            Films = new List<Film>();
            Series = new List<Serie>();
        }

        public List<Film> Films
        {
            get;
            set;
        }
        public List<Serie> Series
        {
            get;
            set;
        }
    }
}