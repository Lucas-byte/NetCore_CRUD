// <auto-generated />
using System;
using Data.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.EF.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.UserEF", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("BrithDate")
                        .HasColumnName("DataAniversario")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnName("DataCriacao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnName("DataDelecao")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnName("Email")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnName("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnName("Senha")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrithDate = new DateTime(2022, 2, 1, 18, 38, 19, 725, DateTimeKind.Local).AddTicks(7660),
                            CreationDate = new DateTime(2022, 2, 1, 18, 38, 19, 725, DateTimeKind.Local).AddTicks(323),
                            Email = "administrador@email.com.br",
                            Name = "Administrador",
                            Password = "admin@123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
