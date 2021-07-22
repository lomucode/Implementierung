using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using testcsharpAPI.models;

#nullable disable

namespace testcsharp.models
{
    public partial class ATHENATONContext : DbContext
    {
        public ATHENATONContext()
        {
        }

        public ATHENATONContext(DbContextOptions<ATHENATONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<BeitragUni> BeitragUnis { get; set; }
        public virtual DbSet<Chartdatum> Chartdata { get; set; }
        public virtual DbSet<DistanDaten> DistanDatens { get; set; }
        public virtual DbSet<EmployeeDb> EmployeeDbs { get; set; }
        public virtual DbSet<MenuMaster> MenuMasters { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SportArt> SportArts { get; set; }
        public virtual DbSet<TblSensorsDatum> TblSensorsData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ubi19.informatik.uni-siegen.de;Initial Catalog=ATHENATON;User ID=gruppe03-1;Password=ath123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Agent>(entity =>
            {
                entity.Property(e => e.AgentId)
                    .ValueGeneratedNever()
                    .HasColumnName("AgentID");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Bild).HasColumnType("image");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.RolleId).HasColumnName("RolleID");

                entity.Property(e => e.Tatigkeit).HasMaxLength(50);

                entity.Property(e => e.Universitätszugehörigkeit).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<BeitragUni>(entity =>
            {
                entity.ToTable("Beitrag_Uni");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Universitätszugehörigkeit)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<Chartdatum>(entity =>
            {
                entity.HasKey(e => e.ChartDataId)
                    .HasName("PK__CHARTDAT__21E9F5BBF8AB926A");

                entity.ToTable("CHARTDATA");

                entity.Property(e => e.ChartTimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DistanDaten>(entity =>
            {
                entity.ToTable("Distan_Daten");

                entity.Property(e => e.DistanDatenDatum).HasColumnType("date");

                entity.Property(e => e.DistanzArt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Distanz_Art");

                entity.Property(e => e.DistanzManuellAnpassen).HasColumnName("Distanz_manuell_Anpassen");

                entity.Property(e => e.UserId).HasMaxLength(100);
            });

            modelBuilder.Entity<EmployeeDb>(entity =>
            {
                entity.ToTable("EmployeeDB");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<MenuMaster>(entity =>
            {
                entity.HasKey(e => new { e.MenuIdentity, e.MenuId, e.MenuName });

                entity.ToTable("MenuMaster");

                entity.Property(e => e.MenuIdentity).ValueGeneratedOnAdd();

                entity.Property(e => e.MenuId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MenuID");

                entity.Property(e => e.MenuName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MenuFileName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MenuUrl)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MenuURL");

                entity.Property(e => e.ParentMenuId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Parent_MenuID");

                entity.Property(e => e.UseYn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("USE_YN")
                    .HasDefaultValueSql("('Y')")
                    .IsFixedLength(true);

                entity.Property(e => e.UserRoll)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("User_Roll");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.Bild).HasColumnType("image");

                entity.Property(e => e.Content)
                    .IsUnicode(false)
                    .HasColumnName("content");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Zeit)
                    .HasColumnType("date")
                    .HasColumnName("zeit");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Product");

                entity.Property(e => e.Bame)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<SportArt>(entity =>
            {
                entity.ToTable("SportArt");

                entity.Property(e => e.Art)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblSensorsDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_sensors_data");

                entity.Property(e => e.SensorsDataDate)
                    .HasColumnType("date")
                    .HasColumnName("sensors_data_date");

                entity.Property(e => e.SensorsDataId).HasColumnName("sensors_data_id");

                entity.Property(e => e.SensorsDataTime).HasColumnName("sensors_data_time");

                entity.Property(e => e.SensorsTemperatureData)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("sensors_temperature_data");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<testcsharpAPI.models.DistanDaten> DistanDaten { get; set; }
    }
}
