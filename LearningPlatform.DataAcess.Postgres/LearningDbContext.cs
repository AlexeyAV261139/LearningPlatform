using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.DataAccess.Postgres
{
    public class LearningDbContext : DbContext
    {
        public LearningDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CourseEntity> Courses { get; set; }

        public DbSet<LessonEntity> Lessons { get; set; }

        public DbSet<AuthorEntity> Authors { get; set; }

        public DbSet<StudentEntity> Students { get; set; }

    }
}
