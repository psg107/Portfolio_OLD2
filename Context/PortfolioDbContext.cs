using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Portfolio.Entities;

namespace Portfolio.Context
{
    /// <summary>
    /// <para>1.  add-migration Init</para>
    /// <para>2.  update-database</para>
    /// <para>3~. add-migration ~~</para>
    /// </summary>
    public class PortfolioDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public PortfolioDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var connectionString = configuration.GetConnectionString("SqlServerConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProjectSkill>()
                        .HasKey(x => new { x.ProjectId, x.SkillId });
            modelBuilder.Entity<Skill>()
                        .Property(x => x.SkillId)
                        .ValueGeneratedOnAdd();
            modelBuilder.Entity<Project>()
                        .Property(x => x.ProjectId)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<ProjectSkill>()
                        .HasOne(x => x.Skill)
                        .WithMany(x => x.ProjectSkills)
                        .HasForeignKey(x => x.SkillId);
            modelBuilder.Entity<ProjectSkill>()
                        .HasOne(x => x.Project)
                        .WithMany(x => x.ProjectSkills)
                        .HasForeignKey(x => x.ProjectId);

            var (skills, projects, projectSkills) = PortfolioDbContextSeed.GenerateSeed();

            modelBuilder.Entity<Skill>().HasData(skills);
            modelBuilder.Entity<Project>().HasData(projects);
            modelBuilder.Entity<ProjectSkill>().HasData(projectSkills);
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Skill> Skills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Project> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProjectSkill> ProjectSkills { get; set; }
    }
}
