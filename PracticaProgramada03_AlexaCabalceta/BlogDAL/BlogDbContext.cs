using Microsoft.EntityFrameworkCore;

namespace BlogDAL
{
    public class BlogDbContext: DbContext
    {
        public BlogDbContext() { }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer();
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
    }
}
