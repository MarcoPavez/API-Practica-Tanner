using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace api_front.Models;

public partial class CsharpApiContext : DbContext
{
    public CsharpApiContext()
    {
    }

    public CsharpApiContext(DbContextOptions<CsharpApiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<OrdenCompra> OrdenCompras { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__categori__A3C02A10C8BBCA3A");

            entity.ToTable("categoria");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdenCompra>(entity =>
        {
            entity.HasKey(e => e.IdOrden).HasName("PK__orden_co__33F95B58BE48BFE9");

            entity.ToTable("orden_compra");

            entity.Property(e => e.IdOrden).HasColumnName("Id_orden");
            entity.Property(e => e.IdProducto).HasColumnName("Id_producto");
            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK_orden_compra_producto");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.OrdenCompras)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK_orden_compra_usuario");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__producto__098892103529FDE7");

            entity.ToTable("producto");

            entity.Property(e => e.CodigoBarra)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Marca)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK_IDCATEGORIA");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC0741A908CE");

            entity.ToTable("usuario");

            entity.Property(e => e.Cell)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.First)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Last)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Md5)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nat)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PictureLarge)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PictureMedium)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PictureThumbnail)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Postcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegisteredDate).HasColumnType("datetime");
            entity.Property(e => e.Salt)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Seed)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sha1)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sha256)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TimezoneDescription)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TimezoneOffset)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Uuid)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
