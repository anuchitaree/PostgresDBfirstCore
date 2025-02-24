using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PostgresDBfirstCore.Models
{
    public partial class TimecardContext : DbContext
    {
        public TimecardContext()
        {
        }

        public TimecardContext(DbContextOptions<TimecardContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LogRecord> LogRecords { get; set; } = null!;
        public virtual DbSet<TimecardRecord> TimecardRecords { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=Timecard;Username=postgres;Password=admin");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogRecord>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(40);

                entity.Property(e => e.Decription).HasMaxLength(100);

                entity.Property(e => e.Result).HasMaxLength(5);
            });

            modelBuilder.Entity<TimecardRecord>(entity =>
            {
                entity.Property(e => e.ChildLineId).HasMaxLength(7);

                entity.Property(e => e.EmpId).HasMaxLength(7);

                entity.Property(e => e.MachineSn).HasMaxLength(4);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
