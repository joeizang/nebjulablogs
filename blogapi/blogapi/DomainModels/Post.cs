using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogapi.DomainModels
{
    public class Post : BaseEntity
    {

        public string Title { get; set; }

        public string PostBody { get; set; }

        public List<Comment> Comments { get; set; }

        public List<Reaction> Reactions { get; set; }

        public List<Asset> Assets { get; set; }

        public Author Author { get; set; }

        public Guid AuthorId { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
