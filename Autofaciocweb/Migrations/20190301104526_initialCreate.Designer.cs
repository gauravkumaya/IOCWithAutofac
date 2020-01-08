﻿// <auto-generated />
using System;
using Autofaciocweb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Autofaciocweb.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20190301104526_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Autofaciocweb.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Coursename");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Autofaciocweb.Models.RegStudent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(20);

                    b.Property<int?>("age");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("RegStudent");
                });

            modelBuilder.Entity("Autofaciocweb.Models.RegStudent", b =>
                {
                    b.HasOne("Autofaciocweb.Models.Course", "CurrentCourse")
                        .WithMany("regStudents")
                        .HasForeignKey("CourseId");
                });
#pragma warning restore 612, 618
        }
    }
}
