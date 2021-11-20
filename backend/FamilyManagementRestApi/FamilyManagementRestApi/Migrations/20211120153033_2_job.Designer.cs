﻿// <auto-generated />
using System;
using FamilyManagementRestApi.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilyManagementRestApi.Migrations
{
    [DbContext(typeof(FamilyDbContext))]
    [Migration("20211120153033_2_job")]
    partial class _2_job
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("ChildInterest", b =>
                {
                    b.Property<int>("ChildrenId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InterestsType")
                        .HasColumnType("TEXT");

                    b.HasKey("ChildrenId", "InterestsType");

                    b.HasIndex("InterestsType");

                    b.ToTable("ChildInterest");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Adult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("JobSalary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.HasIndex("JobTitle", "JobSalary");

                    b.ToTable("Adults");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Child", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("EyeColor")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HairColor")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sex")
                        .HasColumnType("TEXT");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Family", b =>
                {
                    b.Property<string>("StreetName")
                        .HasColumnType("TEXT");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("StreetName", "HouseNumber");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Interest", b =>
                {
                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("Interest");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Job", b =>
                {
                    b.Property<string>("JobTitle")
                        .HasColumnType("TEXT");

                    b.Property<int>("Salary")
                        .HasColumnType("INTEGER");

                    b.HasKey("JobTitle", "Salary");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ChildId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FamilyHouseNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FamilyStreetName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Species")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ChildId");

                    b.HasIndex("FamilyStreetName", "FamilyHouseNumber");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("ChildInterest", b =>
                {
                    b.HasOne("FamilyManagementRestApi.Models.Child", null)
                        .WithMany()
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyManagementRestApi.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Adult", b =>
                {
                    b.HasOne("FamilyManagementRestApi.Models.Family", null)
                        .WithMany("Adults")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");

                    b.HasOne("FamilyManagementRestApi.Models.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobTitle", "JobSalary");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Child", b =>
                {
                    b.HasOne("FamilyManagementRestApi.Models.Family", null)
                        .WithMany("Children")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Pet", b =>
                {
                    b.HasOne("FamilyManagementRestApi.Models.Child", null)
                        .WithMany("Pets")
                        .HasForeignKey("ChildId");

                    b.HasOne("FamilyManagementRestApi.Models.Family", null)
                        .WithMany("Pets")
                        .HasForeignKey("FamilyStreetName", "FamilyHouseNumber");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Child", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("FamilyManagementRestApi.Models.Family", b =>
                {
                    b.Navigation("Adults");

                    b.Navigation("Children");

                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}