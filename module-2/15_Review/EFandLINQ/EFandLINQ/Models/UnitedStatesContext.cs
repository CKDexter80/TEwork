using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EFandLINQ.Models
{
    public partial class UnitedStatesContext : DbContext
    {
        public UnitedStatesContext()
        {
        }

        public UnitedStatesContext(DbContextOptions<UnitedStatesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Park> Parks { get; set; }
        public virtual DbSet<ParkState> ParkStates { get; set; }
        public virtual DbSet<State> States { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=UnitedStates;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("city");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.Area)
                    .HasColumnType("decimal(5, 1)")
                    .HasColumnName("area");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_name");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.Property(e => e.StateAbbreviation)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("state_abbreviation")
                    .IsFixedLength(true);

                entity.HasOne(d => d.StateAbbreviationNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.StateAbbreviation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_city_state");
            });

            modelBuilder.Entity<Park>(entity =>
            {
                entity.ToTable("park");

                entity.HasIndex(e => e.ParkName, "UQ_park_name")
                    .IsUnique();

                entity.Property(e => e.ParkId).HasColumnName("park_id");

                entity.Property(e => e.Area)
                    .HasColumnType("decimal(6, 1)")
                    .HasColumnName("area");

                entity.Property(e => e.DateEstablished)
                    .HasColumnType("date")
                    .HasColumnName("date_established");

                entity.Property(e => e.HasCamping).HasColumnName("has_camping");

                entity.Property(e => e.ParkName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("park_name");
            });

            modelBuilder.Entity<ParkState>(entity =>
            {
                entity.HasKey(e => new { e.ParkId, e.StateAbbreviation });

                entity.ToTable("park_state");

                entity.Property(e => e.ParkId).HasColumnName("park_id");

                entity.Property(e => e.StateAbbreviation)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("state_abbreviation")
                    .IsFixedLength(true);

                entity.HasOne(d => d.Park)
                    .WithMany(p => p.ParkStates)
                    .HasForeignKey(d => d.ParkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_park_state_park");

                entity.HasOne(d => d.StateAbbreviationNavigation)
                    .WithMany(p => p.ParkStates)
                    .HasForeignKey(d => d.StateAbbreviation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_park_state_state");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.StateAbbreviation);

                entity.ToTable("state");

                entity.HasIndex(e => e.StateName, "UQ_state_name")
                    .IsUnique();

                entity.HasIndex(e => e.StateNickname, "UQ_state_nickname")
                    .IsUnique()
                    .HasFilter("([state_nickname] IS NOT NULL)");

                entity.Property(e => e.StateAbbreviation)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("state_abbreviation")
                    .IsFixedLength(true);

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.Capital).HasColumnName("capital");

                entity.Property(e => e.CensusRegion)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("census_region");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.Property(e => e.SalesTax)
                    .HasColumnType("decimal(5, 3)")
                    .HasColumnName("sales_tax");

                entity.Property(e => e.StateName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state_name");

                entity.Property(e => e.StateNickname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("state_nickname");

                entity.HasOne(d => d.CapitalNavigation)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.Capital)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_state_city");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
