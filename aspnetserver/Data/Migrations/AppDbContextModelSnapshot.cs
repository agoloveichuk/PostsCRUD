﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetserver.Data;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("aspnetserver.Data.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PostId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Content = "This is content to Post 1",
                            Title = "Post 1"
                        },
                        new
                        {
                            PostId = 2,
                            Content = "This is content to Post 2",
                            Title = "Post 2"
                        },
                        new
                        {
                            PostId = 3,
                            Content = "This is content to Post 3",
                            Title = "Post 3"
                        },
                        new
                        {
                            PostId = 4,
                            Content = "This is content to Post 4",
                            Title = "Post 4"
                        },
                        new
                        {
                            PostId = 5,
                            Content = "This is content to Post 5",
                            Title = "Post 5"
                        },
                        new
                        {
                            PostId = 6,
                            Content = "This is content to Post 6",
                            Title = "Post 6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
