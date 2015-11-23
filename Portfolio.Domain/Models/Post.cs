using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Domain.Models
{
    public class Post : EntityBase
    {

        public virtual Category Category { get; set; }
        public virtual IList<Tag> Tags { get; set; }
    }
}
