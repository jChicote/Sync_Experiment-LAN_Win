﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SyncNotesAppTest_Windows.Application.Data;

#nullable disable

namespace SyncNotesAppTest_Windows.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("SyncNotesAppTest_Windows.Models.Device", b =>
                {
                    b.Property<Guid>("DeviceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AssociatedUserID")
                        .HasColumnType("TEXT");

                    b.HasKey("DeviceID");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("SyncNotesAppTest_Windows.Models.Note", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastUpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("OwningUserID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TextContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("SyncNotesAppTest_Windows.Models.SyncChanges", b =>
                {
                    b.Property<Guid>("ChangeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ChangeData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DeviceID")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("EntityID")
                        .HasColumnType("TEXT");

                    b.Property<int>("EntityType")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsSynced")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Operation")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("ChangeID");

                    b.ToTable("SyncChanges");
                });

            modelBuilder.Entity("SyncNotesAppTest_Windows.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
