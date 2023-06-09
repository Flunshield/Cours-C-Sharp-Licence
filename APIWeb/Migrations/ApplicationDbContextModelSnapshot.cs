﻿// <auto-generated />
using APIWeb.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIWeb.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("APIWeb.Entities.Enemy", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("IdWeapon")
                        .HasColumnType("bigint");

                    b.Property<string>("classePlayer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("strength")
                        .HasColumnType("bigint");

                    b.Property<long>("vitality")
                        .HasColumnType("bigint");

                    b.Property<long>("wisdom")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Enemys");
                });

            modelBuilder.Entity("APIWeb.Entities.Hero", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("IdWeapon")
                        .HasColumnType("bigint");

                    b.Property<string>("classePlayer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("strength")
                        .HasColumnType("bigint");

                    b.Property<long>("vitality")
                        .HasColumnType("bigint");

                    b.Property<long>("wisdom")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("APIWeb.Entities.Weapon", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("EnemysNameArms")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HeroesNameArms")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("bonusStrength")
                        .HasColumnType("bigint");

                    b.Property<long>("bonusVitality")
                        .HasColumnType("bigint");

                    b.Property<long>("bonusWisdom")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Arms");
                });
#pragma warning restore 612, 618
        }
    }
}
