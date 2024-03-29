﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using CapstoneProjects.Models;
using CapstoneProjects.DataAccess;

#nullable disable

namespace Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230409100015_AddDepToDB")]
    partial class AddDepToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Web.Models.Department", b =>
                {
                    b.Property<int>("DepID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepID"), 1L, 1);

                    b.Property<string>("DepNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepID");

                    b.ToTable("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}
