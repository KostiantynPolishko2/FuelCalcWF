﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CmdDbMSSQL.Models
{
    public partial class db_aa7fda_edmond171195001Context : DbContext
    {
        public db_aa7fda_edmond171195001Context()
        {
        }

        public db_aa7fda_edmond171195001Context(DbContextOptions<db_aa7fda_edmond171195001Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Auto_db> Auto_dbs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=sql5105.site4now.net;Initial Catalog=db_aa7fda_edmond171195001;User ID=db_aa7fda_edmond171195001_admin;Password=Edmond1711");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto_db>(entity =>
            {
                entity.HasKey(e => e.auto_db_id).HasName("PK__Auto_db__73622013D82F09B2");

                entity.ToTable("Auto_db");

                entity.Property(e => e.mark).HasMaxLength(100);
                entity.Property(e => e.model).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
