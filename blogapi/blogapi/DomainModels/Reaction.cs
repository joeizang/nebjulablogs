namespace blogapi.DomainModels
{
    public class Reaction : BaseEntity
    {
        public string ReactionName { get; set; }

        public ReactionType ReactionType { get; set; }
    }
}