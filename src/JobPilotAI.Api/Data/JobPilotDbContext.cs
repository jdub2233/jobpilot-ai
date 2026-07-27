using JobPilotAI.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPilotAI.Api.Data;

public class JobPilotDbContext : DbContext
{
    public JobPilotDbContext(DbContextOptions<JobPilotDbContext> options)
        : base(options)
    {
    }

    public DbSet<Employer> Employers => Set<Employer>();

    public DbSet<JobPosition> JobPositions => Set<JobPosition>();

    public DbSet<JobApplication> JobApplications => Set<JobApplication>();

    public DbSet<ApplicationStatusHistory> ApplicationStatusHistories => Set<ApplicationStatusHistory>();

    public DbSet<FollowUpReminder> FollowUpReminders => Set<FollowUpReminder>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<JobPosition>()
            .HasOne(jp => jp.Employer)
            .WithMany(e => e.JobPositions)
            .HasForeignKey(jp => jp.EmployerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<JobApplication>()
            .HasOne(ja => ja.JobPosition)
            .WithMany(jp => jp.JobApplications)
            .HasForeignKey(ja => ja.JobPositionId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<ApplicationStatusHistory>()
            .HasOne(ash => ash.JobApplication)
            .WithMany(ja => ja.ApplicationStatusHistories)
            .HasForeignKey(ash => ash.JobApplicationId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<FollowUpReminder>()
            .HasOne(fr => fr.JobApplication)
            .WithMany(ja => ja.FollowUpReminders)
            .HasForeignKey(fr => fr.JobApplicationId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Employer>()
            .Property(e => e.Name)
            .HasMaxLength(200);

        modelBuilder.Entity<Employer>()
            .Property(e => e.WebsiteUrl)
            .HasMaxLength(500);

        modelBuilder.Entity<Employer>()
            .Property(e => e.Industry)
            .HasMaxLength(150);

        modelBuilder.Entity<JobPosition>()
            .Property(jp => jp.Title)
            .HasMaxLength(200);

        modelBuilder.Entity<JobPosition>()
            .Property(jp => jp.Location)
            .HasMaxLength(200);

        modelBuilder.Entity<JobPosition>()
            .Property(jp => jp.EmploymentType)
            .HasMaxLength(50);

        modelBuilder.Entity<JobPosition>()
            .Property(jp => jp.JobPostingUrl)
            .HasMaxLength(1000);

        modelBuilder.Entity<JobPosition>()
            .Property(jp => jp.SalaryMinimum)
            .HasPrecision(12, 2);

        modelBuilder.Entity<JobPosition>()
            .Property(jp => jp.SalaryMaximum)
            .HasPrecision(12, 2);

        modelBuilder.Entity<JobApplication>()
            .Property(ja => ja.CurrentStatus)
            .HasMaxLength(50);

        modelBuilder.Entity<JobApplication>()
            .Property(ja => ja.Source)
            .HasMaxLength(100);

        modelBuilder.Entity<ApplicationStatusHistory>()
            .Property(ash => ash.Status)
            .HasMaxLength(50);

        modelBuilder.Entity<FollowUpReminder>()
            .Property(fr => fr.ReminderType)
            .HasMaxLength(100);
    }
}