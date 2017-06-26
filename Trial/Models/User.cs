using System;
using System.Collections.Generic;

namespace Trial.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Collection> Collections { get; set; }
    }

}