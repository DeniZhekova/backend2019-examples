﻿// <auto-generated />
using Lesson12.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lesson12.Migrations
{
    [DbContext(typeof(Lesson12Context))]
    partial class Lesson12ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lesson12.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new { AuthorId = 1, Name = "Jane Austen" },
                        new { AuthorId = 2, Name = "Charles Dickens" },
                        new { AuthorId = 3, Name = "Miguel de Cervantes" }
                    );
                });

            modelBuilder.Entity("Lesson12.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title");

                    b.Property<int>("Year");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");

                    b.HasData(
                        new { BookId = 1, AuthorId = 1, Genre = "Comedy of manners", Price = 9.99m, Title = "Pride and Prejudice", Year = 1813 },
                        new { BookId = 2, AuthorId = 1, Genre = "Gothic parody", Price = 12.95m, Title = "Northanger Abbey", Year = 1817 },
                        new { BookId = 3, AuthorId = 2, Genre = "Bildungsroman", Price = 15m, Title = "David Copperfield", Year = 1850 },
                        new { BookId = 4, AuthorId = 3, Genre = "Picaresque", Price = 8.95m, Title = "Don Quixote", Year = 1617 }
                    );
                });

            modelBuilder.Entity("Lesson12.Models.Book", b =>
                {
                    b.HasOne("Lesson12.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
