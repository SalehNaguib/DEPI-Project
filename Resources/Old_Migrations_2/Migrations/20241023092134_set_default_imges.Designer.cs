﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineCoursesApp.DAL.Models;

#nullable disable

namespace OnlineCoursesApp.DAL.Migrations
{
    [DbContext(typeof(OnlineCoursesContext))]
    [Migration("20241023092134_set_default_imges")]
    partial class set_default_imges
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.Property<int>("CoursesCourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsStudentId")
                        .HasColumnType("int");

                    b.HasKey("CoursesCourseId", "StudentsStudentId");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

                    b.HasData(
                        new
                        {
                            Id = "4181d5b0-d91e-4f6b-8b4f-9086643e6b4e",
                            Name = "SuperAdmin",
                            NormalizedName = "SUPERADMIN"
                        },
                        new
                        {
                            Id = "6bc12c01-c25f-4c0e-a972-07acb1a2205c",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "19aa2745-b7bc-4bf4-abd6-6a342d3a90da",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "710cc79b-7beb-452a-b970-6bd62c0f5851",
                            Name = "Instructor",
                            NormalizedName = "INSTRUCTOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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
                            Id = "9ecef325-35c9-43e3-aea6-396981c2897b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4e03e5dd-e6e6-408f-858a-ace6813d97c2",
                            Email = "superAdmin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@MAIL.COM",
                            NormalizedUserName = "SUPERADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEK3qg1ySMNMBXrPTCsv/8S5ayKsvxUytIaaOD4zYeN0ZdE2xublK2g1pjcrPRR0h8Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3c0c0a8c-bd55-46d3-94ea-d5c5a1bb03c5",
                            TwoFactorEnabled = false,
                            UserName = "superAdmin@mail.com"
                        },
                        new
                        {
                            Id = "1b1b18f7-2a8b-4297-9aed-7dd76f26b09b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d57a0692-6b7b-4922-bb19-dce0db2f68b4",
                            Email = "admin@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEDBpFrNh69V1hX6wS+2mKZAgN0+RW7lce8I4nY5CbEPv3MnVIMylAY/HaOXTy+hzPg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9c3a328a-7b5d-4f8b-ac80-42ef56e717d8",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "96daf944-376d-4cd5-b092-2e0740e959f2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8e16fab1-a644-406e-8e7b-82c5aefab18b",
                            Email = "student@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT@MAIL.COM",
                            NormalizedUserName = "STUDENT@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEO1fmbR7ny8GS4kGJZnaIkQKaz5+0r2POznVJutoaiiFDgWT+8Zjj2W6Rh3HgQPR0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "73f5da9c-86ff-4b8c-929b-0040c5ea0e4d",
                            TwoFactorEnabled = false,
                            UserName = "student@mail.com"
                        },
                        new
                        {
                            Id = "8a5301db-3b1b-4a99-8fd1-7e03b00ec621",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "22fe7583-091a-4b58-b9d6-637f9e233dd1",
                            Email = "instructor@mail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUCTOR@MAIL.COM",
                            NormalizedUserName = "INSTRUCTOR@MAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEAzhW2xYV3moBqQcDfMA6Gq1BFmAF7O35Xexm35pOjB8BMG4h6Lk+MI7wVLkXEbhug==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7fb5b3fb-3c2e-4321-bb60-1a614556a74c",
                            TwoFactorEnabled = false,
                            UserName = "instructor@mail.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "9ecef325-35c9-43e3-aea6-396981c2897b",
                            RoleId = "4181d5b0-d91e-4f6b-8b4f-9086643e6b4e"
                        },
                        new
                        {
                            UserId = "9ecef325-35c9-43e3-aea6-396981c2897b",
                            RoleId = "6bc12c01-c25f-4c0e-a972-07acb1a2205c"
                        },
                        new
                        {
                            UserId = "1b1b18f7-2a8b-4297-9aed-7dd76f26b09b",
                            RoleId = "6bc12c01-c25f-4c0e-a972-07acb1a2205c"
                        },
                        new
                        {
                            UserId = "96daf944-376d-4cd5-b092-2e0740e959f2",
                            RoleId = "19aa2745-b7bc-4bf4-abd6-6a342d3a90da"
                        },
                        new
                        {
                            UserId = "8a5301db-3b1b-4a99-8fd1-7e03b00ec621",
                            RoleId = "710cc79b-7beb-452a-b970-6bd62c0f5851"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.BlackList", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Email");

                    b.ToTable("BlackLists");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseId"));

                    b.Property<int>("CourseStatus")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructorId"));

                    b.Property<string>("About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstructorId");

                    b.HasIndex("IdentityUserID");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            InstructorId = -1,
                            AccountStatus = 0,
                            Email = "instructor@mail.com",
                            IdentityUserID = "8a5301db-3b1b-4a99-8fd1-7e03b00ec621",
                            Image = "F:\\CSE_56\\DEPI\\DEPI_Project\\Project_Source_Code\\DEPI-Project\\OnlineCoursesApp\\OnlineCoursesApp\\wwwroot\\image\\default_profil _mage5.png",
                            Name = "instructor Seed"
                        });
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Section", b =>
                {
                    b.Property<int>("SectionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SectionId"));

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SectionId");

                    b.HasIndex("CourseId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentId"));

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("IdentityUserID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = -1,
                            AccountStatus = 0,
                            Email = "student@mail.com",
                            IdentityUserID = "96daf944-376d-4cd5-b092-2e0740e959f2",
                            Image = "F:\\CSE_56\\DEPI\\DEPI_Project\\Project_Source_Code\\DEPI-Project\\OnlineCoursesApp\\OnlineCoursesApp\\wwwroot\\image\\Student\\default.png",
                            Name = "Student Seed"
                        });
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.StudentProgress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SectionId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentProgresses");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.WebAdmin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityUserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("IdentityUserID");

                    b.ToTable("WebAdmins");

                    b.HasData(
                        new
                        {
                            ID = -1,
                            AccountStatus = 0,
                            Email = "superAdmin@mail.com",
                            IdentityUserID = "9ecef325-35c9-43e3-aea6-396981c2897b",
                            Name = "Super Admin"
                        },
                        new
                        {
                            ID = -2,
                            AccountStatus = 0,
                            Email = "admin@mail.com",
                            IdentityUserID = "1b1b18f7-2a8b-4297-9aed-7dd76f26b09b",
                            Name = "Normal Admin"
                        });
                });

            modelBuilder.Entity("CourseStudent", b =>
                {
                    b.HasOne("OnlineCoursesApp.DAL.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesCourseId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("OnlineCoursesApp.DAL.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStudentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Course", b =>
                {
                    b.HasOne("OnlineCoursesApp.DAL.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Instructor", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Section", b =>
                {
                    b.HasOne("OnlineCoursesApp.DAL.Models.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Course");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Student", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.StudentProgress", b =>
                {
                    b.HasOne("OnlineCoursesApp.DAL.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCoursesApp.DAL.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineCoursesApp.DAL.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Section");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.WebAdmin", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "IdentityUser")
                        .WithMany()
                        .HasForeignKey("IdentityUserID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("IdentityUser");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("OnlineCoursesApp.DAL.Models.Instructor", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
