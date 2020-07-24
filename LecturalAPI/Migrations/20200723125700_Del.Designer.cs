﻿// <auto-generated />
using System;
using LecturalAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LecturalAPI.Migrations
{
    [DbContext(typeof(AppdbContext))]
    [Migration("20200723125700_Del")]
    partial class Del
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LecturalAPI.Models.CadetDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("birthDay")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dateOfStartService")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isMarried")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("militaryRank")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pathPhotoBig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pathPhotoSmall")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("GroupDBid");

                    b.ToTable("Cadet");
                });

            modelBuilder.Entity("LecturalAPI.Models.DisciplineDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Lecturalid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<Guid?>("SpecializationDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("countHours")
                        .HasColumnType("int");

                    b.Property<int>("countNorm")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfPlan")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isExam")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Lecturalid");

                    b.HasIndex("SpecializationDBid");

                    b.ToTable("Discipline");
                });

            modelBuilder.Entity("LecturalAPI.Models.GroupDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CountCadets")
                        .HasColumnType("int");

                    b.Property<Guid>("ProfessionDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SpecializationDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOfGroup")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ProfessionDBid");

                    b.HasIndex("SpecializationDBid");

                    b.ToTable("Group");
                });

            modelBuilder.Entity("LecturalAPI.Models.Lectural", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AcademicDegreeid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AcademicTitleid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MilitaryRankid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Positionid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("birthDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("countOfChildren")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateOfStartService")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isMarried")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("middleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pathPhotoBig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pathPhotoSmall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serialAndNumderCivilyDocs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("serialAndNumderMilitaryDocs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("AcademicDegreeid");

                    b.HasIndex("AcademicTitleid");

                    b.HasIndex("MilitaryRankid");

                    b.HasIndex("Positionid");

                    b.ToTable("Lectural");
                });

            modelBuilder.Entity("LecturalAPI.Models.LessonTypeDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameOfType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("shortNameOfType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("LessonType");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.AcademicDegree", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AcademicDegree");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.AcademicTitle", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("AcademicTitle");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.LessonDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Disciplineid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InfoForLectural")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Lecturalid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LessonTypeDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("auditoreNumber")
                        .HasColumnType("int");

                    b.Property<int>("countHours")
                        .HasColumnType("int");

                    b.Property<int>("currentNumberOflessonsType")
                        .HasColumnType("int");

                    b.Property<string>("infoForCadets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("infoForEngeneer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sectionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("themeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Disciplineid");

                    b.HasIndex("Lecturalid");

                    b.HasIndex("LessonTypeDBid");

                    b.ToTable("Lesson");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.MilitaryRank", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("MilitaryRank");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.Position", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("koeff")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.ProfessionDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameOfProffession")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("proffesionCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Profession");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.SpecializationDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SpecializationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nameOfSpecialization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Specialization");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.TimetableDB", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DisciplineDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GroupDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LessonDBid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("dateOfLesson")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("firstLecturalid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("infoForEngeneers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("infoForLectural")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("infoForcadets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numberOfAud")
                        .HasColumnType("int");

                    b.Property<int>("numberOfLesson")
                        .HasColumnType("int");

                    b.Property<int>("numberOfWeek")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("DisciplineDBid");

                    b.HasIndex("GroupDBid");

                    b.HasIndex("LessonDBid");

                    b.HasIndex("firstLecturalid");

                    b.ToTable("Timetable");
                });

            modelBuilder.Entity("LecturalAPI.Models.CadetDB", b =>
                {
                    b.HasOne("LecturalAPI.Models.GroupDB", "GroupDB")
                        .WithMany("CadetDB")
                        .HasForeignKey("GroupDBid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LecturalAPI.Models.DisciplineDB", b =>
                {
                    b.HasOne("LecturalAPI.Models.Lectural", null)
                        .WithMany("DisciplineDB")
                        .HasForeignKey("Lecturalid");

                    b.HasOne("LecturalAPI.Models.dataBaseModel.SpecializationDB", "SpecializationDB")
                        .WithMany("DisciplineDB")
                        .HasForeignKey("SpecializationDBid");
                });

            modelBuilder.Entity("LecturalAPI.Models.GroupDB", b =>
                {
                    b.HasOne("LecturalAPI.Models.dataBaseModel.ProfessionDB", "ProfessionDB")
                        .WithMany("GroupDB")
                        .HasForeignKey("ProfessionDBid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LecturalAPI.Models.dataBaseModel.SpecializationDB", "SpecializationDB")
                        .WithMany("GroupDB")
                        .HasForeignKey("SpecializationDBid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LecturalAPI.Models.Lectural", b =>
                {
                    b.HasOne("LecturalAPI.Models.dataBaseModel.AcademicDegree", "AcademicDegree")
                        .WithMany()
                        .HasForeignKey("AcademicDegreeid");

                    b.HasOne("LecturalAPI.Models.dataBaseModel.AcademicTitle", "AcademicTitle")
                        .WithMany()
                        .HasForeignKey("AcademicTitleid");

                    b.HasOne("LecturalAPI.Models.dataBaseModel.MilitaryRank", "MilitaryRank")
                        .WithMany()
                        .HasForeignKey("MilitaryRankid");

                    b.HasOne("LecturalAPI.Models.dataBaseModel.Position", "Position")
                        .WithMany()
                        .HasForeignKey("Positionid");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.LessonDB", b =>
                {
                    b.HasOne("LecturalAPI.Models.DisciplineDB", "Discipline")
                        .WithMany("lessonDBs")
                        .HasForeignKey("Disciplineid");

                    b.HasOne("LecturalAPI.Models.Lectural", "Lectural")
                        .WithMany("LessonDBs")
                        .HasForeignKey("Lecturalid");

                    b.HasOne("LecturalAPI.Models.LessonTypeDB", "LessonTypeDB")
                        .WithMany("lessonDbs")
                        .HasForeignKey("LessonTypeDBid");
                });

            modelBuilder.Entity("LecturalAPI.Models.dataBaseModel.TimetableDB", b =>
                {
                    b.HasOne("LecturalAPI.Models.DisciplineDB", "DisciplineDB")
                        .WithMany("TimetableDB")
                        .HasForeignKey("DisciplineDBid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LecturalAPI.Models.GroupDB", "GroupDB")
                        .WithMany("TimetableDB")
                        .HasForeignKey("GroupDBid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LecturalAPI.Models.dataBaseModel.LessonDB", "LessonDB")
                        .WithMany("TimetableDB")
                        .HasForeignKey("LessonDBid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LecturalAPI.Models.Lectural", "firstLectural")
                        .WithMany("TimetableDB")
                        .HasForeignKey("firstLecturalid");
                });
#pragma warning restore 612, 618
        }
    }
}
