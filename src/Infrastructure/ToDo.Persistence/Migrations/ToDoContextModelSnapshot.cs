﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDo.Persistence.Context;

#nullable disable

namespace ToDo.Persistence.Migrations
{
    [DbContext(typeof(ToDoContext))]
    partial class ToDoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ToDo.Domain.Entities.Role.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<string>("ParentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5141),
                            Description = "",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5144),
                            Title = "Creator"
                        },
                        new
                        {
                            Id = "2",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5157),
                            Description = "",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5159),
                            Title = "Admin"
                        },
                        new
                        {
                            Id = "3",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5173),
                            Description = "",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(5186),
                            Title = "User"
                        });
                });

            modelBuilder.Entity("ToDo.Domain.Entities.ToDo.Plan", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNotification")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Plans");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2547),
                            Description = "",
                            IsActive = true,
                            IsDelete = false,
                            IsNotification = true,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2549),
                            Time = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2560),
                            Title = "School",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "2",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2595),
                            Description = "",
                            IsActive = true,
                            IsDelete = false,
                            IsNotification = true,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2601),
                            Time = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2604),
                            Title = "School2",
                            UserId = "1"
                        },
                        new
                        {
                            Id = "3",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2637),
                            Description = "",
                            IsActive = true,
                            IsDelete = false,
                            IsNotification = true,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2639),
                            Time = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(2642),
                            Title = "School3",
                            UserId = "1"
                        });
                });

            modelBuilder.Entity("ToDo.Domain.Entities.User.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModify")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberIsActive")
                        .HasColumnType("bit");

                    b.Property<long>("PlanCount")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Birthday = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7368),
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7374),
                            Email = "Test@test.com",
                            FirstName = "Test",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7376),
                            LastName = "Test",
                            PhoneNumber = "09100000000",
                            PhoneNumberIsActive = true,
                            PlanCount = 3L
                        },
                        new
                        {
                            Id = "2",
                            Birthday = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7389),
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7392),
                            Email = "Test2@test.com",
                            FirstName = "Test2",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7394),
                            LastName = "Test2",
                            PhoneNumber = "09110000000",
                            PhoneNumberIsActive = true,
                            PlanCount = 0L
                        },
                        new
                        {
                            Id = "3",
                            Birthday = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7405),
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7408),
                            Email = "Test3@test.com",
                            FirstName = "Test3",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 561, DateTimeKind.Local).AddTicks(7410),
                            LastName = "Test3",
                            PhoneNumber = "09120000000",
                            PhoneNumberIsActive = true,
                            PlanCount = 0L
                        });
                });

            modelBuilder.Entity("ToDo.Domain.Entities.User.UserRoles", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModify")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1",
                            RoleId = "1",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9517),
                            Id = "1",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9519)
                        },
                        new
                        {
                            UserId = "1",
                            RoleId = "2",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9532),
                            Id = "1",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9535)
                        },
                        new
                        {
                            UserId = "1",
                            RoleId = "3",
                            CreateDate = new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9545),
                            Id = "1",
                            IsActive = true,
                            IsDelete = false,
                            LastModify = new DateTime(2023, 6, 22, 6, 56, 11, 562, DateTimeKind.Local).AddTicks(9548)
                        });
                });

            modelBuilder.Entity("ToDo.Domain.Entities.ToDo.Plan", b =>
                {
                    b.HasOne("ToDo.Domain.Entities.User.User", "User")
                        .WithMany("Plans")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDo.Domain.Entities.User.UserRoles", b =>
                {
                    b.HasOne("ToDo.Domain.Entities.Role.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ToDo.Domain.Entities.User.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ToDo.Domain.Entities.Role.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("ToDo.Domain.Entities.User.User", b =>
                {
                    b.Navigation("Plans");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
