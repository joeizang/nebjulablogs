using System;
using System.Collections.Generic;

namespace blogapi.DomainModels
{
    public class Author : BaseEntity
    {
        public string AuthorName { get; set; }

        public string AuthorEmail { get; set; }

        public string Bio { get; set; }

        public string PreferredTechStack { get; set; }

        public Asset Asset { get; set; }

        public Guid AssetId { get; set; }

        public List<Post> Posts { get; set; }
    }
}