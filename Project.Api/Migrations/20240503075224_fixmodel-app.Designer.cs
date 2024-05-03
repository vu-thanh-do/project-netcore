﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Project.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240503075224_fixmodel-app")]
    partial class fixmodelapp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AppointmentsServices", b =>
                {
                    b.Property<int>("AppointmentsId")
                        .HasColumnType("int");

                    b.Property<int>("ServicesServiceId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentsId", "ServicesServiceId");

                    b.HasIndex("ServicesServiceId");

                    b.ToTable("AppointmentsServices");
                });

            modelBuilder.Entity("Project.Api.Models.AppointmentHistory", b =>
                {
                    b.Property<int>("HistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoryID"), 1L, 1);

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AppointmentID")
                        .HasColumnType("int");

                    b.Property<int?>("DoctorsDoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialtiesSpecialtyID")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HistoryID");

                    b.HasIndex("AppointmentID");

                    b.HasIndex("DoctorsDoctorId");

                    b.HasIndex("SpecialtiesSpecialtyID");

                    b.HasIndex("UserId");

                    b.ToTable("AppointmentHistory");
                });

            modelBuilder.Entity("Project.Api.Models.Appointments", b =>
                {
                    b.Property<int>("AppointmentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentsId"), 1L, 1);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ClinicID")
                        .HasColumnType("int");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int?>("SpecialtiesSpecialtyID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AppointmentsId");

                    b.HasIndex("ClinicID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("SpecialtiesSpecialtyID");

                    b.HasIndex("UserID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Project.Api.Models.Clinics", b =>
                {
                    b.Property<int>("ClinicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClinicID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClinicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClinicID");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("Project.Api.Models.Doctors", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecialtyID")
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DoctorId");

                    b.HasIndex("SpecialtyID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Project.Api.Models.MedicalRecords", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("RecordID");

                    b.HasIndex("DoctorID");

                    b.HasIndex("UserID");

                    b.ToTable("MedicalRecords");
                });

            modelBuilder.Entity("Project.Api.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Project.Api.Models.Services", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"), 1L, 1);

                    b.Property<int?>("ClinicsClinicID")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceId");

                    b.HasIndex("ClinicsClinicID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Project.Api.Models.Specialties", b =>
                {
                    b.Property<int>("SpecialtyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialtyID"), 1L, 1);

                    b.Property<string>("SpecialtyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecialtyID");

                    b.ToTable("Specialties");
                });

            modelBuilder.Entity("Project.Api.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AppointmentsServices", b =>
                {
                    b.HasOne("Project.Api.Models.Appointments", null)
                        .WithMany()
                        .HasForeignKey("AppointmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Api.Models.Services", null)
                        .WithMany()
                        .HasForeignKey("ServicesServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Project.Api.Models.AppointmentHistory", b =>
                {
                    b.HasOne("Project.Api.Models.Appointments", "Appointment")
                        .WithMany("AppointmentHistories")
                        .HasForeignKey("AppointmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Api.Models.Doctors", null)
                        .WithMany("AppointmentHistories")
                        .HasForeignKey("DoctorsDoctorId");

                    b.HasOne("Project.Api.Models.Specialties", null)
                        .WithMany("AppointmentHistories")
                        .HasForeignKey("SpecialtiesSpecialtyID");

                    b.HasOne("Project.Api.Models.User", null)
                        .WithMany("AppointmentHistories")
                        .HasForeignKey("UserId");

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("Project.Api.Models.Appointments", b =>
                {
                    b.HasOne("Project.Api.Models.Clinics", "Clinic")
                        .WithMany("Appointments")
                        .HasForeignKey("ClinicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Api.Models.Doctors", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Api.Models.Specialties", null)
                        .WithMany("Appointments")
                        .HasForeignKey("SpecialtiesSpecialtyID");

                    b.HasOne("Project.Api.Models.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Doctor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Api.Models.Doctors", b =>
                {
                    b.HasOne("Project.Api.Models.Specialties", "Specialty")
                        .WithMany("Doctors")
                        .HasForeignKey("SpecialtyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("Project.Api.Models.MedicalRecords", b =>
                {
                    b.HasOne("Project.Api.Models.Doctors", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project.Api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Api.Models.Services", b =>
                {
                    b.HasOne("Project.Api.Models.Clinics", null)
                        .WithMany("Services")
                        .HasForeignKey("ClinicsClinicID");
                });

            modelBuilder.Entity("Project.Api.Models.User", b =>
                {
                    b.HasOne("Project.Api.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Project.Api.Models.Appointments", b =>
                {
                    b.Navigation("AppointmentHistories");
                });

            modelBuilder.Entity("Project.Api.Models.Clinics", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Services");
                });

            modelBuilder.Entity("Project.Api.Models.Doctors", b =>
                {
                    b.Navigation("AppointmentHistories");

                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Project.Api.Models.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("Project.Api.Models.Specialties", b =>
                {
                    b.Navigation("AppointmentHistories");

                    b.Navigation("Appointments");

                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Project.Api.Models.User", b =>
                {
                    b.Navigation("AppointmentHistories");

                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
