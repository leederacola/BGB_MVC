using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trial.Models
{
    public class Collection
    {
        public int CollectionID { get; set; }
        public int GameID { get; set; }
        public int UserID { get; set; }

        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
    }
}