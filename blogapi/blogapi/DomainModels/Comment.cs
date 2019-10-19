using System;
using System.Collections.Generic;

namespace blogapi.DomainModels
{
    public class Comment : BaseEntity
    {
        public string CommentBody { get; set; }

        public string CommentAuthor { get; set; }

        public Guid AssetId { get; set; }

        public Asset Asset { get; set; }

        public bool CanBePublished { get; set; }

        public List<Comment> Replies { get; set; }

        public List<Reaction> Reactions { get; set; }
    }
}