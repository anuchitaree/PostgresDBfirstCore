using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PostgresDBfirstCore.Models
{
    public partial class dekidaka_local_dbContext : DbContext
    {
        public dekidaka_local_dbContext()
        {
        }

        public dekidaka_local_dbContext(DbContextOptions<dekidaka_local_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlembicVersion> AlembicVersions { get; set; } = null!;
        public virtual DbSet<DailyPlan> DailyPlans { get; set; } = null!;
        public virtual DbSet<DashboardTransactionScan> DashboardTransactionScans { get; set; } = null!;
        public virtual DbSet<Interlock> Interlocks { get; set; } = null!;
        public virtual DbSet<Line> Lines { get; set; } = null!;
        public virtual DbSet<LineGroup> LineGroups { get; set; } = null!;
        public virtual DbSet<LineStation> LineStations { get; set; } = null!;
        public virtual DbSet<Manpower> Manpowers { get; set; } = null!;
        public virtual DbSet<ManpowerByLine> ManpowerByLines { get; set; } = null!;
        public virtual DbSet<MasterFactory> MasterFactories { get; set; } = null!;
        public virtual DbSet<MasterFactoryTime> MasterFactoryTimes { get; set; } = null!;
        public virtual DbSet<MasterLoss> MasterLosses { get; set; } = null!;
        public virtual DbSet<MasterLossByLine> MasterLossByLines { get; set; } = null!;
        public virtual DbSet<MasterLotSize> MasterLotSizes { get; set; } = null!;
        public virtual DbSet<Part> Parts { get; set; } = null!;
        public virtual DbSet<PartsChangeOver> PartsChangeOvers { get; set; } = null!;
        public virtual DbSet<PartsInLine> PartsInLines { get; set; } = null!;
        public virtual DbSet<QrGenerate> QrGenerates { get; set; } = null!;
        public virtual DbSet<ScanBuffer> ScanBuffers { get; set; } = null!;
        public virtual DbSet<ShiftMasterDetail> ShiftMasterDetails { get; set; } = null!;
        public virtual DbSet<ShiftPattern> ShiftPatterns { get; set; } = null!;
        public virtual DbSet<ShiftPatternDetailForoperation> ShiftPatternDetailForoperations { get; set; } = null!;
        public virtual DbSet<ShiftSlot> ShiftSlots { get; set; } = null!;
        public virtual DbSet<UserAccessLog> UserAccessLogs { get; set; } = null!;
        public virtual DbSet<UserManagement> UserManagements { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=192.168.100.117;Port=5450;Database=dekidaka_local_db;Username=postgres;Password=a1234A#A4321a");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AlembicVersion>(entity =>
            {
                entity.HasKey(e => e.VersionNum)
                    .HasName("alembic_version_pkc");

                entity.ToTable("alembic_version");

                entity.Property(e => e.VersionNum)
                    .HasMaxLength(32)
                    .HasColumnName("version_num");
            });

            modelBuilder.Entity<DailyPlan>(entity =>
            {
                entity.ToTable("daily_plan");

                entity.HasIndex(e => e.Id, "ix_daily_plan_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Ct).HasColumnName("ct");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .HasColumnName("end_time");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.IsDay).HasColumnName("is_day");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.Manpower).HasColumnName("manpower");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(30)
                    .HasColumnName("part_no");

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .HasColumnName("shift_id");

                entity.Property(e => e.ShiftTeam)
                    .HasMaxLength(10)
                    .HasColumnName("shift_team");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(5)
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<DashboardTransactionScan>(entity =>
            {
                entity.ToTable("dashboard_transaction_scan");

                entity.HasIndex(e => e.DateTime, "ix_dashboard_transaction_scan_date_time");

                entity.HasIndex(e => e.Id, "ix_dashboard_transaction_scan_id");

                entity.HasIndex(e => e.LineId, "ix_dashboard_transaction_scan_line_id");

                entity.HasIndex(e => e.TypeScan, "ix_dashboard_transaction_scan_type_scan");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.DateTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("date_time");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(30)
                    .HasColumnName("part_no");

                entity.Property(e => e.TypeScan)
                    .HasMaxLength(40)
                    .HasColumnName("type_scan");

                entity.Property(e => e.ValueScan)
                    .HasColumnType("character varying")
                    .HasColumnName("value_scan");
            });

            modelBuilder.Entity<Interlock>(entity =>
            {
                entity.ToTable("interlock");

                entity.HasIndex(e => e.FactoryId, "ix_interlock_factory_id");

                entity.HasIndex(e => e.Id, "ix_interlock_id");

                entity.HasIndex(e => e.LineId, "ix_interlock_line_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasColumnType("character varying")
                    .HasColumnName("factory_id");

                entity.Property(e => e.IsLock).HasColumnName("is_lock");

                entity.Property(e => e.LineId)
                    .HasColumnType("character varying")
                    .HasColumnName("line_id");

                entity.Property(e => e.LockType)
                    .HasColumnType("character varying")
                    .HasColumnName("lock_type");
            });

            modelBuilder.Entity<Line>(entity =>
            {
                entity.ToTable("line");

                entity.HasIndex(e => e.FactoryId, "ix_line_factory_id");

                entity.HasIndex(e => e.Id, "ix_line_id");

                entity.HasIndex(e => e.LineId, "ix_line_line_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(100)
                    .HasColumnName("line_group_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.LineIdV2)
                    .HasMaxLength(100)
                    .HasColumnName("line_id_v2");

                entity.Property(e => e.LineName)
                    .HasMaxLength(100)
                    .HasColumnName("line_name");

                entity.Property(e => e.LineNameV2)
                    .HasMaxLength(100)
                    .HasColumnName("line_name_v2");

                entity.Property(e => e.OaTarget).HasColumnName("oa_target");

                entity.Property(e => e.ShiftDayId)
                    .HasMaxLength(10)
                    .HasColumnName("shift_day_id");

                entity.Property(e => e.ShiftNightId)
                    .HasMaxLength(10)
                    .HasColumnName("shift_night_id");
            });

            modelBuilder.Entity<LineGroup>(entity =>
            {
                entity.ToTable("line_group");

                entity.HasIndex(e => e.Id, "ix_line_group_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(100)
                    .HasColumnName("line_group_id");

                entity.Property(e => e.LineGroupIdV2)
                    .HasMaxLength(100)
                    .HasColumnName("line_group_id_v2");

                entity.Property(e => e.LineGroupName)
                    .HasMaxLength(100)
                    .HasColumnName("line_group_name");

                entity.Property(e => e.LineGroupNameV2)
                    .HasMaxLength(100)
                    .HasColumnName("line_group_name_v2");
            });

            modelBuilder.Entity<LineStation>(entity =>
            {
                entity.ToTable("line_station");

                entity.HasIndex(e => e.Id, "ix_line_station_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.ChildEquIdV2)
                    .HasMaxLength(100)
                    .HasColumnName("child_equ_id_v2");

                entity.Property(e => e.ChildEquNameV2)
                    .HasMaxLength(100)
                    .HasColumnName("child_equ_name_v2");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.StationId)
                    .HasMaxLength(100)
                    .HasColumnName("station_id");

                entity.Property(e => e.StationName)
                    .HasMaxLength(100)
                    .HasColumnName("station_name");
            });

            modelBuilder.Entity<Manpower>(entity =>
            {
                entity.ToTable("manpower");

                entity.HasIndex(e => e.Id, "ix_manpower_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .HasColumnName("emp_id");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(100)
                    .HasColumnName("emp_name");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");
            });

            modelBuilder.Entity<ManpowerByLine>(entity =>
            {
                entity.ToTable("manpower_by_line");

                entity.HasIndex(e => e.Id, "ix_manpower_by_line_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .HasColumnName("emp_id");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");
            });

            modelBuilder.Entity<MasterFactory>(entity =>
            {
                entity.ToTable("master_factory");

                entity.HasIndex(e => e.FactoryId, "ix_master_factory_factory_id");

                entity.HasIndex(e => e.Id, "ix_master_factory_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(100)
                    .HasColumnName("factory_code");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.OaTarget).HasColumnName("oa_target");
            });

            modelBuilder.Entity<MasterFactoryTime>(entity =>
            {
                entity.ToTable("master_factory_time");

                entity.HasIndex(e => e.FactoryId, "ix_master_factory_time_factory_id");

                entity.HasIndex(e => e.Id, "ix_master_factory_time_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");
            });

            modelBuilder.Entity<MasterLoss>(entity =>
            {
                entity.ToTable("master_loss");

                entity.HasIndex(e => e.Id, "ix_master_loss_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LossCode)
                    .HasMaxLength(50)
                    .HasColumnName("loss_code");

                entity.Property(e => e.LossId)
                    .HasMaxLength(10)
                    .HasColumnName("loss_id");

                entity.Property(e => e.LossName)
                    .HasColumnType("character varying")
                    .HasColumnName("loss_name");
            });

            modelBuilder.Entity<MasterLossByLine>(entity =>
            {
                entity.ToTable("master_loss_by_line");

                entity.HasIndex(e => e.Id, "ix_master_loss_by_line_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.LossId)
                    .HasMaxLength(10)
                    .HasColumnName("loss_id");
            });

            modelBuilder.Entity<MasterLotSize>(entity =>
            {
                entity.ToTable("master_lot_size");

                entity.HasIndex(e => e.Id, "ix_master_lot_size_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(30)
                    .HasColumnName("part_no");

                entity.Property(e => e.Size).HasColumnName("size");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.ToTable("parts");

                entity.HasIndex(e => e.FactoryId, "ix_parts_factory_id");

                entity.HasIndex(e => e.Id, "ix_parts_id");

                entity.HasIndex(e => e.PartNo, "ix_parts_part_no")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .HasColumnName("model");

                entity.Property(e => e.PartName)
                    .HasMaxLength(30)
                    .HasColumnName("part_name");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(30)
                    .HasColumnName("part_no");
            });

            modelBuilder.Entity<PartsChangeOver>(entity =>
            {
                entity.ToTable("parts_change_over");

                entity.HasIndex(e => e.Id, "ix_parts_change_over_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.PartChange)
                    .HasMaxLength(50)
                    .HasColumnName("part_change");

                entity.Property(e => e.PartOg)
                    .HasMaxLength(50)
                    .HasColumnName("part_og");

                entity.Property(e => e.TimeDelayMinute).HasColumnName("time_delay_minute");
            });

            modelBuilder.Entity<PartsInLine>(entity =>
            {
                entity.ToTable("parts_in_line");

                entity.HasIndex(e => e.FactoryId, "ix_parts_in_line_factory_id");

                entity.HasIndex(e => e.Id, "ix_parts_in_line_id");

                entity.HasIndex(e => e.LineId, "ix_parts_in_line_line_id");

                entity.HasIndex(e => e.PartNo, "ix_parts_in_line_part_no");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Ct).HasColumnName("ct");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.LineId)
                    .HasMaxLength(100)
                    .HasColumnName("line_id");

                entity.Property(e => e.Manpower).HasColumnName("manpower");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(30)
                    .HasColumnName("part_no");
            });

            modelBuilder.Entity<QrGenerate>(entity =>
            {
                entity.ToTable("qr_generate");

                entity.HasIndex(e => e.Id, "ix_qr_generate_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Details)
                    .HasMaxLength(50)
                    .HasColumnName("details");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.QrId)
                    .HasMaxLength(10)
                    .HasColumnName("qr_id");
            });

            modelBuilder.Entity<ScanBuffer>(entity =>
            {
                entity.ToTable("scan_buffer");

                entity.HasIndex(e => e.ActiveTime, "ix_scan_buffer_active_time");

                entity.HasIndex(e => e.CodeScan, "ix_scan_buffer_code_scan");

                entity.HasIndex(e => e.CodeType, "ix_scan_buffer_code_type");

                entity.HasIndex(e => e.FactoryId, "ix_scan_buffer_factory_id");

                entity.HasIndex(e => new { e.FactoryId, e.LineId, e.OperationalDate, e.ShiftId }, "ix_scan_buffer_factory_line_date_shift");

                entity.HasIndex(e => e.Id, "ix_scan_buffer_id");

                entity.HasIndex(e => e.LineId, "ix_scan_buffer_line_id");

                entity.HasIndex(e => e.OperationalDate, "ix_scan_buffer_operational_date");

                entity.HasIndex(e => e.ShiftId, "ix_scan_buffer_shift_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.ActiveTime)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("active_time");

                entity.Property(e => e.CodeScan).HasColumnName("code_scan");

                entity.Property(e => e.CodeType)
                    .HasColumnType("character varying")
                    .HasColumnName("code_type");

                entity.Property(e => e.DetailShow)
                    .HasColumnType("character varying")
                    .HasColumnName("detail_show");

                entity.Property(e => e.FactoryId)
                    .HasColumnType("character varying")
                    .HasColumnName("factory_id");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.LineId)
                    .HasColumnType("character varying")
                    .HasColumnName("line_id");

                entity.Property(e => e.OperationalDate).HasColumnName("operational_date");

                entity.Property(e => e.RawScan)
                    .HasColumnType("character varying")
                    .HasColumnName("raw_scan");

                entity.Property(e => e.ShiftId)
                    .HasColumnType("character varying")
                    .HasColumnName("shift_id");
            });

            modelBuilder.Entity<ShiftMasterDetail>(entity =>
            {
                entity.ToTable("shift_master_detail");

                entity.HasIndex(e => e.FactoryId, "ix_shift_master_detail_factory_id");

                entity.HasIndex(e => e.Id, "ix_shift_master_detail_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.DetailId)
                    .HasMaxLength(10)
                    .HasColumnName("detail_id");

                entity.Property(e => e.DetailName)
                    .HasColumnType("character varying")
                    .HasColumnName("detail_name");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ShiftPattern>(entity =>
            {
                entity.ToTable("shift_pattern");

                entity.HasIndex(e => e.FactoryId, "ix_shift_pattern_factory_id");

                entity.HasIndex(e => e.Id, "ix_shift_pattern_id");

                entity.HasIndex(e => e.ShiftId, "ix_shift_pattern_shift_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.IsDay).HasColumnName("is_day");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .HasColumnName("shift_id");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(100)
                    .HasColumnName("shift_name");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<ShiftPatternDetailForoperation>(entity =>
            {
                entity.ToTable("shift_pattern_detail_foroperation");

                entity.HasIndex(e => e.Id, "ix_shift_pattern_detail_foroperation_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Color)
                    .HasMaxLength(30)
                    .HasColumnName("color");

                entity.Property(e => e.DetailId)
                    .HasMaxLength(10)
                    .HasColumnName("detail_id");

                entity.Property(e => e.DurationTime).HasColumnName("duration_time");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.FactoryId)
                    .HasMaxLength(20)
                    .HasColumnName("factory_id");

                entity.Property(e => e.ShiftId)
                    .HasMaxLength(10)
                    .HasColumnName("shift_id");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ShiftSlot>(entity =>
            {
                entity.ToTable("shift_slot");

                entity.HasIndex(e => e.FactoryId, "ix_shift_slot_factory_id");

                entity.HasIndex(e => new { e.FactoryId, e.LineId, e.ShiftId, e.OperationalDate }, "ix_shift_slot_factory_line_shift_date");

                entity.HasIndex(e => e.Id, "ix_shift_slot_id");

                entity.HasIndex(e => e.LineId, "ix_shift_slot_line_id");

                entity.HasIndex(e => e.OperationalDate, "ix_shift_slot_operational_date");

                entity.HasIndex(e => e.ShiftId, "ix_shift_slot_shift_id");

                entity.HasIndex(e => e.Timestamp, "ix_shift_slot_timestamp");

                entity.HasIndex(e => e.WorkShiftId, "ix_shift_slot_work_shift_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Ct).HasColumnName("ct");

                entity.Property(e => e.DurationTime).HasColumnName("duration_time");

                entity.Property(e => e.FactoryId)
                    .HasColumnType("character varying")
                    .HasColumnName("factory_id");

                entity.Property(e => e.IsFull).HasColumnName("is_full");

                entity.Property(e => e.LineId)
                    .HasColumnType("character varying")
                    .HasColumnName("line_id");

                entity.Property(e => e.OperationalDate).HasColumnName("operational_date");

                entity.Property(e => e.OrPercentage).HasColumnName("or_percentage");

                entity.Property(e => e.PlanPerCt).HasColumnName("plan_per_ct");

                entity.Property(e => e.PlanQty).HasColumnName("plan_qty");

                entity.Property(e => e.PlanQtyActual).HasColumnName("plan_qty_actual");

                entity.Property(e => e.PlanScan)
                    .HasColumnType("character varying")
                    .HasColumnName("plan_scan");

                entity.Property(e => e.RemainingTime).HasColumnName("remaining_time");

                entity.Property(e => e.Remark)
                    .HasColumnType("character varying")
                    .HasColumnName("remark");

                entity.Property(e => e.ShiftId)
                    .HasColumnType("character varying")
                    .HasColumnName("shift_id");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("timestamp");

                entity.Property(e => e.WorkShiftId)
                    .HasColumnType("character varying")
                    .HasColumnName("work_shift_id");
            });

            modelBuilder.Entity<UserAccessLog>(entity =>
            {
                entity.ToTable("user_access_log");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.AccessType)
                    .HasColumnType("character varying")
                    .HasColumnName("access_type");

                entity.Property(e => e.IpAddress)
                    .HasColumnType("character varying")
                    .HasColumnName("ip_address");

                entity.Property(e => e.Success).HasColumnName("success");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("timestamp");

                entity.Property(e => e.UserId)
                    .HasColumnType("character varying")
                    .HasColumnName("user_id");

                entity.Property(e => e.Username)
                    .HasColumnType("character varying")
                    .HasColumnName("username");
            });

            modelBuilder.Entity<UserManagement>(entity =>
            {
                entity.ToTable("user_management");

                entity.HasIndex(e => e.Id, "ix_user_management_id");

                entity.Property(e => e.Id)
                    .HasColumnType("character varying")
                    .HasColumnName("id")
                    .HasDefaultValueSql("gen_random_uuid()");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .HasColumnName("password");

                entity.Property(e => e.UserRole)
                    .HasMaxLength(50)
                    .HasColumnName("user_role");

                entity.Property(e => e.Username)
                    .HasColumnType("character varying")
                    .HasColumnName("username");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
