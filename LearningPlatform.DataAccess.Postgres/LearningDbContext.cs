using LearningPlatform.DataAccess.Postgres.Configurations;
using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.DataAccess.Postgres
{
    public class LearningDbContext(DbContextOptions<LearningDbContext> options)
        : DbContext(options)
    {
        public DbSet<CourseEntity> Courses { get; set; }

        public DbSet<LessonEntity> Lessons { get; set; }

        public DbSet<AuthorEntity> Authors { get; set; }

        public DbSet<StudentEntity> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {           
            base.OnModelCreating(modelBuilder);
        }

    }
}
