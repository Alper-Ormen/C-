using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace c_.Models;

public partial class Atp11Context : DbContext
{
    public Atp11Context()
    {
    }

    public Atp11Context(DbContextOptions<Atp11Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Liste> Listes { get; set; }

    public virtual DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;port=3306;user=root;database=atp11", Microsoft.EntityFrameworkCore.ServerVersion.Parse("5.7.36-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<Liste>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("liste");

            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(50)
                .HasDefaultValueSql("''");
        });

        modelBuilder.Entity<Todo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("todos");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.IsComplated).HasColumnType("bit(1)");
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    internal MySqlConnection GetConn()
    {
        throw new NotImplementedException();
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
