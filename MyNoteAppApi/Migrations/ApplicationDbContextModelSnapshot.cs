﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyNoteAppApi.Data;

namespace MyNoteAppApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyNoteAppApi.Data.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Lorem ipsum sit amet,consectetur.",
                            CreateTime = new DateTime(2021, 10, 15, 11, 54, 15, 221, DateTimeKind.Local).AddTicks(527),
                            Title = "Simple note1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Set et luctus dolor, eget ullacorper urna.",
                            CreateTime = new DateTime(2021, 10, 15, 11, 54, 15, 222, DateTimeKind.Local).AddTicks(3823),
                            Title = "Simple note2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}