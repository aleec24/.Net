﻿// <auto-generated />
using System;
using BlogDAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlogDAL.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20240401020751_CamposNoRequired")]
    partial class CamposNoRequired
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogDAL.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BlogDAL.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioCreacionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("BlogId");

                    b.HasIndex("UsuarioCreacionId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogDAL.Comentario", b =>
                {
                    b.Property<int>("ComentarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComentarioId"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsuarioCreacionId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ComentarioId");

                    b.HasIndex("BlogId");

                    b.HasIndex("UsuarioCreacionId");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("BlogDAL.Blog", b =>
                {
                    b.HasOne("BlogDAL.ApplicationUser", "UsuarioCreacion")
                        .WithMany()
                        .HasForeignKey("UsuarioCreacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioCreacion");
                });

            modelBuilder.Entity("BlogDAL.Comentario", b =>
                {
                    b.HasOne("BlogDAL.Blog", "Blog")
                        .WithMany("Comentarios")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlogDAL.ApplicationUser", "UsuarioCreacion")
                        .WithMany()
                        .HasForeignKey("UsuarioCreacionId");

                    b.Navigation("Blog");

                    b.Navigation("UsuarioCreacion");
                });

            modelBuilder.Entity("BlogDAL.Blog", b =>
                {
                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}