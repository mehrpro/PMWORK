


using PMWORK.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace NetSystem.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext() : base("Conn")
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Coding>().HasKey(x => x.ID);
            builder.Entity<Coding>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Entity<Coding>().Property(x => x.CodeIndex).IsRequired();
            builder.Entity<Coding>().Property(x => x.Code).IsRequired();
            builder.Entity<Coding>().Property(x => x.CodeTitle).IsRequired().HasMaxLength(150);
            builder.Entity<Coding>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Coding>()
                .HasMany(x => x.Machineries)
                .WithRequired(x => x.Coding)
                .HasForeignKey(x => x.CodeID_FK)
                .WillCascadeOnDelete(false);




            builder.Entity<Applicant>().HasKey(x => x.ID);
            builder.Entity<Applicant>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            builder.Entity<Applicant>().Property(x => x.ApplicantTitle).IsRequired().HasMaxLength(150);
            builder.Entity<Applicant>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Applicant>()
                .HasMany<RequestRepair>(x => x.RequestRepairs)
                .WithRequired(x => x.Applicant)
                .HasForeignKey(x => x.ApplicantID_FK)
                .WillCascadeOnDelete(false);

            builder.Entity<Company>().HasKey(x => x.ID);
            builder.Entity<Company>().Property(x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            builder.Entity<Company>().Property(x => x.CompnayIndex).IsRequired();
            builder.Entity<Company>().Property(x => x.CompanyTiltle).IsRequired().HasMaxLength(150);
            builder.Entity<Company>().Property(x => x.Description).HasMaxLength(250);
            builder.Entity<Company>()
                .HasMany<Group>(x => x.Groups)
                .WithRequired(x => x.Company)
                .HasForeignKey(x => x.CompanyID_FK)
                .WillCascadeOnDelete(false);
            builder.Entity<Company>()
    .HasMany<SubGroup>(x => x.SubGroups)
    .WithRequired(x => x.Company)
    .HasForeignKey(x => x.CompanyID_FK)
    .WillCascadeOnDelete(false);
            builder.Entity<Company>()
    .HasMany<Coding>(x => x.Codings)
    .WithRequired(x => x.Company)
    .HasForeignKey(x => x.CompanyID_FK)
    .WillCascadeOnDelete(false);

            builder.Entity<ConsumablePart>().HasKey(x => x.ID);
            builder.Entity<ConsumablePart>().Property(x => x.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.ConsumablePartTitel).HasMaxLength(250).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.Number).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.RequestID_FK).IsRequired();
            builder.Entity<ConsumablePart>().Property(x => x.UnitID_FK).IsRequired();







        }



        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Coding> Codings { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConsumablePart> ConsumableParts { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Machinery> Machineries { get; set; }
        public virtual DbSet<RequestRepair> RequestRepairs { get; set; }
        public virtual DbSet<SubGroup> SubGroups { get; set; }
        public virtual DbSet<TypeofRepair> TypeofRepairs { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }
        public virtual DbSet<UnitOfMeasurement> UnitOfMeasurements { get; set; }

    }
}
