// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestPad.DAL.Context;

#nullable disable

namespace TestPad.DAL.Migrations
{
    [DbContext(typeof(TestPadContext))]
    [Migration("20220415223434_ChangeSeeding")]
    partial class ChangeSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "speaks",
                            IsCorrect = true,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "don't speak",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "speak",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "drinks",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Content = "doesn't drink",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "drink",
                            IsCorrect = true,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "play",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            Content = "plays",
                            IsCorrect = true,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 9,
                            Content = "don't play",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 10,
                            Content = "don't love",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 11,
                            Content = "doesn't love",
                            IsCorrect = true,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 12,
                            Content = "love",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 13,
                            Content = "live",
                            IsCorrect = true,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 14,
                            Content = "lives",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 15,
                            Content = "doesn't live",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 16,
                            Content = "long ago",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 17,
                            Content = "last night",
                            IsCorrect = true,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 18,
                            Content = "next Tuesday",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 19,
                            Content = "was a kid",
                            IsCorrect = true,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 20,
                            Content = "meets my mother",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 21,
                            Content = "going to school",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 22,
                            Content = "didn't never lie",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 23,
                            Content = "never lie",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 24,
                            Content = "didn't lie",
                            IsCorrect = true,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 25,
                            Content = "dropped",
                            IsCorrect = true,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 26,
                            Content = "droped",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 27,
                            Content = "drop",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 28,
                            Content = "didn't stay",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 29,
                            Content = "stayed",
                            IsCorrect = true,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 30,
                            Content = "not stayed",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 31,
                            Content = "I'll see",
                            IsCorrect = true,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 32,
                            Content = "I'm see",
                            IsCorrect = false,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 33,
                            Content = "I've seen",
                            IsCorrect = false,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 34,
                            Content = "How many, it will",
                            IsCorrect = false,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 35,
                            Content = "How much, will it",
                            IsCorrect = false,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 36,
                            Content = "How much, it will",
                            IsCorrect = true,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 37,
                            Content = "will never believe",
                            IsCorrect = false,
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 38,
                            Content = "will never believe",
                            IsCorrect = true,
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 39,
                            Content = "won’t never believe",
                            IsCorrect = false,
                            QuestionId = 13
                        },
                        new
                        {
                            Id = 40,
                            Content = "will be",
                            IsCorrect = true,
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 41,
                            Content = "shall be",
                            IsCorrect = false,
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 42,
                            Content = "will been",
                            IsCorrect = false,
                            QuestionId = 14
                        },
                        new
                        {
                            Id = 43,
                            Content = "will not",
                            IsCorrect = true,
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 44,
                            Content = "shan't",
                            IsCorrect = false,
                            QuestionId = 15
                        },
                        new
                        {
                            Id = 45,
                            Content = "won't not",
                            IsCorrect = false,
                            QuestionId = 15
                        });
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Mark ... English.",
                            TestId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "They ... orange juice.",
                            TestId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "A pianist ... the piano.",
                            TestId = 1
                        },
                        new
                        {
                            Id = 4,
                            Content = "Mark ... cakes.",
                            TestId = 1
                        },
                        new
                        {
                            Id = 5,
                            Content = "We ... near the school.",
                            TestId = 1
                        },
                        new
                        {
                            Id = 6,
                            Content = "They got home very late ... .",
                            TestId = 2
                        },
                        new
                        {
                            Id = 7,
                            Content = "My father lived there when he ... .",
                            TestId = 2
                        },
                        new
                        {
                            Id = 8,
                            Content = "He ... to me when he was younger.",
                            TestId = 2
                        },
                        new
                        {
                            Id = 9,
                            Content = "All of a sudden, he ... the ball.",
                            TestId = 2
                        },
                        new
                        {
                            Id = 10,
                            Content = "She never ... alone.",
                            TestId = 2
                        },
                        new
                        {
                            Id = 11,
                            Content = "I can’t come over today. - Okay, then ... you tomorrow.",
                            TestId = 3
                        },
                        new
                        {
                            Id = 12,
                            Content = "My car needs to be repaired. ... do you think ... cost?",
                            TestId = 3
                        },
                        new
                        {
                            Id = 13,
                            Content = "I’ve got some incredible news. You ... what’s happened.",
                            TestId = 3
                        },
                        new
                        {
                            Id = 14,
                            Content = "I think, it ... very hot tomorrow.",
                            TestId = 3
                        },
                        new
                        {
                            Id = 15,
                            Content = "I’m afraid the car ... start.",
                            TestId = 3
                        });
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Description = "Learn how to use the present simple in English. This is an English grammar lesson for beginners or elementary students",
                            Title = "Present Simple"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Description = "Past simple exercises - regular verbs elementary level esl. Beginners exercises.",
                            Title = "Past Simple"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 1,
                            Description = "Online quiz to test your understanding of the Future Simple tense in English.",
                            Title = "Future Simple"
                        });
                });

            modelBuilder.Entity("TestPad.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "87b5c123-7574-49ec-a000-ce8b59476343",
                            Email = "tarreau@live.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "vulcanswimsuit"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b3c055bb-9ebf-4526-90bf-1db1d9bf4ede",
                            Email = "yumpy@att.net",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "investsort"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("TestPad.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("TestPad.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestPad.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("TestPad.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Answer", b =>
                {
                    b.HasOne("TestPad.DAL.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Question", b =>
                {
                    b.HasOne("TestPad.DAL.Entities.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Test", b =>
                {
                    b.HasOne("TestPad.DAL.Entities.User", "Author")
                        .WithMany("Tests")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("TestPad.DAL.Entities.Test", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("TestPad.DAL.Entities.User", b =>
                {
                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
