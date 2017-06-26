using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trial.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }

    }
}