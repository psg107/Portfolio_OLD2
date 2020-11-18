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

            //var connectionString = configuration.GetConnectionString("MysqlConnectionString");
            //optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

#warning 이상하게 appsettings.json에 넣으면 잘 안됨.. 임시로 하드코딩
#if DEBUG
            var connectionString = configuration.GetConnectionString("MysqlConnectionString");
#else
            var connectionString = configuration.GetConnectionString("NaverCloudMySqlConnectionString");
#endif
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProjectSkillEntity>()
                        .HasKey(x => new { x.ProjectId, x.SkillId });
            modelBuilder.Entity<SkillEntity>()
                        .Property(x => x.SkillId)
                        .ValueGeneratedOnAdd();
            modelBuilder.Entity<ProjectEntity>()
                        .Property(x => x.ProjectId)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<ProjectSkillEntity>()
                        .HasOne(x => x.Skill)
                        .WithMany(x => x.ProjectSkills)
                        .HasForeignKey(x => x.SkillId);
            modelBuilder.Entity<ProjectSkillEntity>()
                        .HasOne(x => x.Project)
                        .WithMany(x => x.ProjectSkills)
                        .HasForeignKey(x => x.ProjectId);

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
