using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoFinalSistemaDeRegistroMaferrerWeb.Models;

public partial class MaferrerDbContext : DbContext
{
    public MaferrerDbContext(DbContextOptions<MaferrerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aportacione> Aportaciones { get; set; }

    public virtual DbSet<Habitante> Habitantes { get; set; }

    public virtual DbSet<Incidente> Incidentes { get; set; }

    public virtual DbSet<Visitante> Visitantes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aportacione>(entity =>
        {
            entity.HasKey(e => e.IdAportacion);

            entity.ToTable("aportaciones");

            entity.Property(e => e.IdAportacion).HasColumnName("idAportacion");
            entity.Property(e => e.Concepto)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("concepto");
            entity.Property(e => e.Estado)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdHabitantes).HasColumnName("idHabitantes");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.NumComprobante)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("numComprobante");

            entity.HasOne(d => d.IdHabitantesNavigation).WithMany(p => p.Aportaciones)
                .HasForeignKey(d => d.IdHabitantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_aportaciones_habitantes");
        });

        modelBuilder.Entity<Habitante>(entity =>
        {
            entity.HasKey(e => e.IdHabitantes);

            entity.ToTable("habitantes");

            entity.Property(e => e.IdHabitantes).HasColumnName("idHabitantes");
            entity.Property(e => e.Codigo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("código");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Incidente>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdHabitantes).HasColumnName("idHabitantes");
            entity.Property(e => e.Lugar)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdHabitantesNavigation).WithMany(p => p.Incidentes)
                .HasForeignKey(d => d.IdHabitantes)
                .HasConstraintName("FK_Incidentes_habitantes");
        });

        modelBuilder.Entity<Visitante>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.HoraEntrada)
                .HasColumnType("datetime")
                .HasColumnName("hora_entrada");
            entity.Property(e => e.HoraSalida)
                .HasColumnType("datetime")
                .HasColumnName("hora_salida");
            entity.Property(e => e.IdHabitantes).HasColumnName("idHabitantes");
            entity.Property(e => e.Motivo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("motivo");
            entity.Property(e => e.NombreVisitante)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_visitante");
            entity.Property(e => e.NumeroCasa)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("numero_casa");

            entity.HasOne(d => d.IdHabitantesNavigation).WithMany(p => p.Visitantes)
                .HasForeignKey(d => d.IdHabitantes)
                .HasConstraintName("FK_Visitantes_habitantes");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
