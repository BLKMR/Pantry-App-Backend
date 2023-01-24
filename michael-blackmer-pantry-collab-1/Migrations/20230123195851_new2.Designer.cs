﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using michael_blackmer_pantry_collab_1;

#nullable disable

namespace michaelblackmerpantrycollab1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230123195851_new2")]
    partial class new2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pantry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PantryId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PantryId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Pantry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Pantrys");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FamilyId")
                        .HasColumnType("int");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PantryNAme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Steps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("FamilyId")
                        .HasColumnType("int");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Item", b =>
                {
                    b.HasOne("michael_blackmer_pantry_collab_1.Models.Pantry", null)
                        .WithMany("Items")
                        .HasForeignKey("PantryId");

                    b.HasOne("michael_blackmer_pantry_collab_1.Models.Recipe", null)
                        .WithMany("Items")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Pantry", b =>
                {
                    b.HasOne("michael_blackmer_pantry_collab_1.Models.Family", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Family");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Recipe", b =>
                {
                    b.HasOne("michael_blackmer_pantry_collab_1.Models.Family", null)
                        .WithMany("Recipes")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.User", b =>
                {
                    b.HasOne("michael_blackmer_pantry_collab_1.Models.Family", null)
                        .WithMany("Users")
                        .HasForeignKey("FamilyId");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Family", b =>
                {
                    b.Navigation("Recipes");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Pantry", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("michael_blackmer_pantry_collab_1.Models.Recipe", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
