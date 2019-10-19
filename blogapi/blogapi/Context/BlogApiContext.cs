using blogapi.DomainModels;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogapi.Context
{
    public class BlogApiContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public BlogApiContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> PostComments { get; set; }

        public DbSet<Author> PostAuthors { get; set; }

        public DbSet<Asset> Assets { get; set; }

        public DbSet<Reaction> Reactions { get; set; }

        public DbSet<Tag> PostTags { get; set; }

        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
