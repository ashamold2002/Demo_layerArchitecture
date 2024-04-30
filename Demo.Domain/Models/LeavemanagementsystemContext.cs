using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace Demo.Common.Models;

public partial class LeavemanagementsystemContext : DbContext
{
    public LeavemanagementsystemContext()
    {
    }

    public LeavemanagementsystemContext(DbContextOptions<LeavemanagementsystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admindetail> Admindetails { get; set; }

    public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }

    public virtual DbSet<Employeedetail> Employeedetails { get; set; }

    public virtual DbSet<Leaveallocated> Leaveallocateds { get; set; }

    public virtual DbSet<Leavedetail> Leavedetails { get; set; }

    public virtual DbSet<Leavetype> Leavetypes { get; set; }

    public virtual DbSet<Rolebasedadmin> Rolebasedadmins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=leavemanagementsystem;uid=root;pwd=Password@12345", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.33-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Admindetail>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PRIMARY");

            entity.ToTable("admindetails");
        });

        modelBuilder.Entity<Efmigrationshistory>(entity =>
        {
            entity.HasKey(e => e.MigrationId).HasName("PRIMARY");

            entity.ToTable("__efmigrationshistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Employeedetail>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PRIMARY");

            entity.ToTable("employeedetails");

            entity.Property(e => e.EmployeeId).HasColumnName("Employee_id");
        });

        modelBuilder.Entity<Leaveallocated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("leaveallocateds");

            entity.HasIndex(e => e.EmployeeDetailsEmployeeId, "IX_leaveAllocateds_EmployeeDetailsEmployee_id");

            entity.Property(e => e.Cl).HasColumnName("CL");
            entity.Property(e => e.EmployeeDetailsEmployeeId).HasColumnName("EmployeeDetailsEmployee_id");
            entity.Property(e => e.Lop).HasColumnName("LOP");
            entity.Property(e => e.Ml).HasColumnName("ML");
            entity.Property(e => e.Pl).HasColumnName("PL");

            entity.HasOne(d => d.EmployeeDetailsEmployee).WithMany(p => p.Leaveallocateds)
                .HasForeignKey(d => d.EmployeeDetailsEmployeeId)
                .HasConstraintName("FK_leaveAllocateds_EmployeeDetails_EmployeeDetailsEmployee_id");
        });

        modelBuilder.Entity<Leavedetail>(entity =>
        {
            entity.HasKey(e => e.LeaveId).HasName("PRIMARY");

            entity.ToTable("leavedetails");

            entity.HasIndex(e => e.AdminDetailsAdminId, "IX_leaveDetails_AdminDetailsAdminId");

            entity.HasIndex(e => e.EmployeeDetailsEmployeeId, "IX_leaveDetails_EmployeeDetailsEmployee_id");

            entity.HasIndex(e => e.LeaveTypesId, "IX_leaveDetails_LeaveTypesId");

            entity.Property(e => e.EmployeeDetailsEmployeeId).HasColumnName("EmployeeDetailsEmployee_id");

            entity.HasOne(d => d.AdminDetailsAdmin).WithMany(p => p.Leavedetails)
                .HasForeignKey(d => d.AdminDetailsAdminId)
                .HasConstraintName("FK_leaveDetails_AdminDetails_AdminDetailsAdminId");

            entity.HasOne(d => d.EmployeeDetailsEmployee).WithMany(p => p.Leavedetails)
                .HasForeignKey(d => d.EmployeeDetailsEmployeeId)
                .HasConstraintName("FK_leaveDetails_EmployeeDetails_EmployeeDetailsEmployee_id");

            entity.HasOne(d => d.LeaveTypes).WithMany(p => p.Leavedetails)
                .HasForeignKey(d => d.LeaveTypesId)
                .HasConstraintName("FK_leaveDetails_leaveTypes_LeaveTypesId");
        });

        modelBuilder.Entity<Leavetype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("leavetypes");

            entity.Property(e => e.LeaveType1).HasColumnName("LeaveType");
        });

        modelBuilder.Entity<Rolebasedadmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rolebasedadmins");

            entity.HasIndex(e => e.DetailsAdminId, "IX_roleBasedAdmins_DetailsAdminId");

            entity.HasOne(d => d.DetailsAdmin).WithMany(p => p.Rolebasedadmins)
                .HasForeignKey(d => d.DetailsAdminId)
                .HasConstraintName("FK_roleBasedAdmins_AdminDetails_DetailsAdminId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
