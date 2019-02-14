﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TwaddleGram.Data;

namespace TwaddleGram.Migrations
{
    [DbContext(typeof(TwaddleDbContext))]
    [Migration("20190214031905_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TwaddleGram.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<int>("PostID");

                    b.HasKey("ID");

                    b.HasIndex("PostID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("TwaddleGram.Models.Post", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Caption");

                    b.Property<int>("Photo");

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("TwaddleGram.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Avatar");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TwaddleGram.Models.Comment", b =>
                {
                    b.HasOne("TwaddleGram.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TwaddleGram.Models.Post", b =>
                {
                    b.HasOne("TwaddleGram.Models.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}