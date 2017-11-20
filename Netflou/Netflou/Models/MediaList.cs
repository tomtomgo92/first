using System.Collections.Generic;
using Netflou.Models;

namespace Netflou.Models
{
    public class MediaList
    {
        public MediaList()
        {
            Films = new List<Netflou.Models.Film>();
            Series = new List<Netflou.Models.Serie>();
        }

        public List<Netflou.Models.Film> Films
        {
            get;
            set;
        }
        public List<Netflou.Models.Serie> Series
        {
            get;
            set;
        }
    }
}