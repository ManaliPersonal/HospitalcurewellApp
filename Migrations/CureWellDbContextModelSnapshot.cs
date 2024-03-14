﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using curewellApp.Database;

#nullable disable

namespace curewellApp.Migrations
{
    [DbContext(typeof(CureWellDbContext))]
    partial class CureWellDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("curewellApp.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("varchar(25)");

                    b.HasKey("DoctorID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("curewellApp.Models.DoctorSpecialization", b =>
                {
                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SpecilizationDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("DoctorId", "SpecializationId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("DoctorSpecializations");
                });

            modelBuilder.Entity("curewellApp.Models.Specialization", b =>
                {
                    b.Property<int>("SpecializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SpecilizationCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("SpecilizationName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("SpecializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("curewellApp.Models.Surgery", b =>
                {
                    b.Property<int>("SurgeryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SpecializationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("SurgeryDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("SurgeryId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("SpecializationId");

                    b.ToTable("Surgeries");
                });

            modelBuilder.Entity("curewellApp.Models.DoctorSpecialization", b =>
                {
                    b.HasOne("curewellApp.Models.Doctor", "doctor")
                        .WithMany("doctorSpecializations")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("curewellApp.Models.Specialization", "specialization")
                        .WithMany("doctorSpecializations")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("specialization");
                });

            modelBuilder.Entity("curewellApp.Models.Surgery", b =>
                {
                    b.HasOne("curewellApp.Models.Doctor", "doctor")
                        .WithMany("surgeries")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("curewellApp.Models.Specialization", "specialization")
                        .WithMany("surgeries")
                        .HasForeignKey("SpecializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("specialization");
                });

            modelBuilder.Entity("curewellApp.Models.Doctor", b =>
                {
                    b.Navigation("doctorSpecializations");

                    b.Navigation("surgeries");
                });

            modelBuilder.Entity("curewellApp.Models.Specialization", b =>
                {
                    b.Navigation("doctorSpecializations");

                    b.Navigation("surgeries");
                });
#pragma warning restore 612, 618
        }
    }
}
