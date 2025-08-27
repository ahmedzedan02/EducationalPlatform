namespace EducationalPlatform.Infrastructure;

using EducationalPlatform.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
       
        
    }
    override protected void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Lecture>()
            .HasOne(l => l.Video)
            .WithOne(v => v.Lecture)
            .HasForeignKey<Video>(v => v.LectureId);

    }   
    public DbSet<Student> Students { get; set; }  

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Level> Levels { get; set; }
    public DbSet<Lecture> Lectures { get; set; }
    public DbSet<Video> Videos { get; set; }
    public DbSet<Exam> Exams { get; set; }
    public DbSet<Question> Questions { get; set; }  
    public DbSet<Answer> Answers { get; set; }
    public DbSet<LectureExam>LectureExams { get; set; }

}