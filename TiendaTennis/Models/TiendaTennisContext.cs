/*
 * Autor: Hermilo Amaraz Vargas
 * Fecha de creación: 05/02/2023
 * Fecha de modificación: 05/02/2023
 * Descripción: Se crea el modelo para productos
 */

/*
 * Se usan las librerias del sistema y la generica de colección, tambien se manda a llamar una libreria
 */
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
/*
 * Se declara un ambito de objetos relacionados
 */
namespace TiendaTennis.Models;

public partial class TiendaTennisContext : DbContext
{
    /*
     * se crea la tienda del contexto
     */
    public TiendaTennisContext()
    {
    }

    public TiendaTennisContext(DbContextOptions<TiendaTennisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }
    /*
     * se crea el metodo de tipo void donde se traen todos los datos y se les da un tamaño y se validan del cliente
     */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Clientes_3214EC07B5E863B2");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });
        /*
         * se traen los datos del producto del entity con su tamaño y su nombre
         */
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Producto_3214EC0715F2BC98");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Path)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("path");
            entity.Property(e => e.Producto1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Producto");
        });
        /*
         * se traen los datos del usuario del entity y se les da un tamaño y que no pueden ser nulos.
         */
        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Usuarios_3214EC0797722F61");

            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Contraseña)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }
    /*
    * se crea un modelo de creación parcial de tipo void
    */
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}