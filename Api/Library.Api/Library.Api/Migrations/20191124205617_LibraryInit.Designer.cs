﻿// <auto-generated />
using System;
using Library.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Library.Api.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20191124205617_LibraryInit")]
    partial class LibraryInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Library.Api.Entities.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DateOfDeath")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("25320c5e-f58a-4b1f-b63a-8ee07a840bdf"),
                            DateOfBirth = new DateTimeOffset(new DateTime(1947, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Stephen",
                            Genre = "Horror",
                            LastName = "King"
                        },
                        new
                        {
                            Id = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                            DateOfBirth = new DateTimeOffset(new DateTime(1948, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "George",
                            Genre = "Fantasy",
                            LastName = "RR Martin"
                        },
                        new
                        {
                            Id = new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"),
                            DateOfBirth = new DateTimeOffset(new DateTime(1960, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            FirstName = "Neil",
                            Genre = "Fantasy",
                            LastName = "Gaiman"
                        },
                        new
                        {
                            Id = new Guid("578359b7-1967-41d6-8b87-64ab7605587e"),
                            DateOfBirth = new DateTimeOffset(new DateTime(1958, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            FirstName = "Tom",
                            Genre = "Various",
                            LastName = "Lanoye"
                        },
                        new
                        {
                            Id = new Guid("f74d6899-9ed2-4137-9876-66b070553f8f"),
                            DateOfBirth = new DateTimeOffset(new DateTime(1952, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            FirstName = "Douglas",
                            Genre = "Science fiction",
                            LastName = "Adams"
                        },
                        new
                        {
                            Id = new Guid("a1da1d8e-1988-4634-b538-a01709477b77"),
                            DateOfBirth = new DateTimeOffset(new DateTime(1974, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            FirstName = "Jens",
                            Genre = "Thriller",
                            LastName = "Lapidus"
                        });
                });

            modelBuilder.Entity("Library.Api.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7ba6add-09c4-45f8-8dd0-eaca221e5d93"),
                            AuthorId = new Guid("a1da1d8e-1988-4634-b538-a01709477b77"),
                            Description = "The Shining is a horror novel by American author Stephen King. Published in 1977, it is King's third published novel and first hardback bestseller: the success of the book firmly established King as a preeminent author in the horror genre. ",
                            Title = "The Shining"
                        },
                        new
                        {
                            Id = new Guid("a3749477-f823-4124-aa4a-fc9ad5e79cd6"),
                            AuthorId = new Guid("a1da1d8e-1988-4634-b538-a01709477b77"),
                            Description = "Misery is a 1987 psychological horror novel by Stephen King. This novel was nominated for the World Fantasy Award for Best Novel in 1988, and was later made into a Hollywood film and an off-Broadway play of the same name.",
                            Title = "Misery"
                        },
                        new
                        {
                            Id = new Guid("70a1f9b9-0a37-4c1a-99b1-c7709fc64167"),
                            AuthorId = new Guid("a1da1d8e-1988-4634-b538-a01709477b77"),
                            Description = "It is a 1986 horror novel by American author Stephen King. The story follows the exploits of seven children as they are terrorized by the eponymous being, which exploits the fears and phobias of its victims in order to disguise itself while hunting its prey. 'It' primarily appears in the form of a clown in order to attract its preferred prey of young children.",
                            Title = "It"
                        },
                        new
                        {
                            Id = new Guid("60188a2b-2784-4fc4-8df8-8919ff838b0b"),
                            AuthorId = new Guid("a1da1d8e-1988-4634-b538-a01709477b77"),
                            Description = "The Stand is a post-apocalyptic horror/fantasy novel by American author Stephen King. It expands upon the scenario of his earlier short story 'Night Surf' and outlines the total breakdown of society after the accidental release of a strain of influenza that had been modified for biological warfare causes an apocalyptic pandemic which kills off the majority of the world's human population.",
                            Title = "The Stand"
                        },
                        new
                        {
                            Id = new Guid("447eb762-95e9-4c31-95e1-b20053fbe215"),
                            AuthorId = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                            Description = "A Game of Thrones is the first novel in A Song of Ice and Fire, a series of fantasy novels by American author George R. R. Martin. It was first published on August 1, 1996.",
                            Title = "A Game of Thrones"
                        },
                        new
                        {
                            Id = new Guid("bc4c35c3-3857-4250-9449-155fcf5109ec"),
                            AuthorId = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                            Description = "Forthcoming 6th novel in A Song of Ice and Fire.",
                            Title = "The Winds of Winter"
                        },
                        new
                        {
                            Id = new Guid("09af5a52-9421-44e8-a2bb-a6b9ccbc8239"),
                            AuthorId = new Guid("76053df4-6687-4353-8937-b45556748abe"),
                            Description = "A Dance with Dragons is the fifth of seven planned novels in the epic fantasy series A Song of Ice and Fire by American author George R. R. Martin.",
                            Title = "A Dance with Dragons"
                        },
                        new
                        {
                            Id = new Guid("9edf91ee-ab77-4521-a402-5f188bc0c577"),
                            AuthorId = new Guid("412c3012-d891-4f5e-9613-ff7aa63e6bb3"),
                            Description = "American Gods is a Hugo and Nebula Award-winning novel by English author Neil Gaiman. The novel is a blend of Americana, fantasy, and various strands of ancient and modern mythology, all centering on the mysterious and taciturn Shadow.",
                            Title = "American Gods"
                        },
                        new
                        {
                            Id = new Guid("01457142-358f-495f-aafa-fb23de3d67e9"),
                            AuthorId = new Guid("578359b7-1967-41d6-8b87-64ab7605587e"),
                            Description = "Good-natured and often humorous, Speechless is at times a 'song of curses', as Lanoye describes the conflicts with his beloved diva of a mother and her brave struggle with decline and death.",
                            Title = "Speechless"
                        },
                        new
                        {
                            Id = new Guid("e57b605f-8b3c-4089-b672-6ce9e6d6c23f"),
                            AuthorId = new Guid("f74d6899-9ed2-4137-9876-66b070553f8f"),
                            Description = "The Hitchhiker's Guide to the Galaxy is the first of five books in the Hitchhiker's Guide to the Galaxy comedy science fiction 'trilogy' by Douglas Adams.",
                            Title = "The Hitchhiker's Guide to the Galaxy"
                        },
                        new
                        {
                            Id = new Guid("1325360c-8253-473a-a20f-55c269c20407"),
                            AuthorId = new Guid("a1da1d8e-1988-4634-b538-a01709477b77"),
                            Description = "Easy Money or Snabba cash is a novel from 2006 by Jens Lapidus. It has been a success in term of sales, and the paperback was the fourth best seller of Swedish novels in 2007.",
                            Title = "Easy Money"
                        });
                });

            modelBuilder.Entity("Library.Api.Entities.Book", b =>
                {
                    b.HasOne("Library.Api.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}