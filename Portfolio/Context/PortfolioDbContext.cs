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

            modelBuilder.Entity<ProjectSkillEntity>().HasKey(new string[] { nameof(ProjectSkillEntity.ProjectId), nameof(ProjectSkillEntity.SkillId) });

            var (skills, projects, projectSkills) = PortfolioDbContextSeed.GenerateData();

            modelBuilder.Entity<SkillEntity>().HasData(skills);
            modelBuilder.Entity<ProjectEntity>().HasData(projects);
            modelBuilder.Entity<ProjectSkillEntity>().HasData(projectSkills);
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<SkillEntity> Skills { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProjectEntity> Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<ProjectSkillEntity> ProjectSkills { get; set; }
    }
}
