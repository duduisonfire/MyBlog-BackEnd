﻿// <auto-generated />
using System;
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230728194449_AddedPostImageToDB")]
    partial class AddedPostImageToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("API.Posts", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Post");

                    b.Property<string>("PostAuthor")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PostAuthor");

                    b.Property<string>("PostCategory")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PostCategory");

                    b.Property<string>("PostDescription")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("PostDescription");

                    b.Property<string>("PostImage")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("POstImage");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("PostTitle");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("PostTitle")
                        .IsUnique();

                    b.ToTable("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}