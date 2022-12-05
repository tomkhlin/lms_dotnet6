﻿// <auto-generated />
using LMSweb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMSweb.Migrations
{
    [DbContext(typeof(LMSmodel))]
    [Migration("20221202094131_add_teacher_seed_data")]
    partial class add_teacher_seed_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LMSweb.Models.Course", b =>
                {
                    b.Property<string>("CID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAddMetacognition")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAddPeerAssessmemt")
                        .HasColumnType("bit");

                    b.Property<string>("TID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CID");

                    b.HasIndex("TID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("LMSweb.Models.Group", b =>
                {
                    b.Property<string>("GID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("LMSweb.Models.KnowledgePoint", b =>
                {
                    b.Property<int>("KPID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KPID"), 1L, 1);

                    b.Property<string>("CID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("KPContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KPID");

                    b.HasIndex("CID");

                    b.ToTable("KnowledgePoints");
                });

            modelBuilder.Entity("LMSweb.Models.Mission", b =>
                {
                    b.Property<string>("MID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsAssess")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCoding")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDiscuss")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDrawing")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGReflect")
                        .HasColumnType("bit");

                    b.Property<bool>("IsGoalSetting")
                        .HasColumnType("bit");

                    b.Property<bool>("IsJourney")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReflect")
                        .HasColumnType("bit");

                    b.Property<string>("MDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelateKP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MID");

                    b.HasIndex("CID");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("LMSweb.Models.Student", b =>
                {
                    b.Property<string>("SID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SID");

                    b.HasIndex("CID");

                    b.HasIndex("GID");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            SID = "S001",
                            Password = "S001",
                            SName = "測試學生1",
                            Sex = "男"
                        },
                        new
                        {
                            SID = "S002",
                            Password = "S002",
                            SName = "測試學生2",
                            Sex = "男"
                        },
                        new
                        {
                            SID = "S003",
                            Password = "S003",
                            SName = "測試學生3",
                            Sex = "女"
                        },
                        new
                        {
                            SID = "S004",
                            Password = "S004",
                            SName = "測試學生4",
                            Sex = "女"
                        });
                });

            modelBuilder.Entity("LMSweb.Models.Teacher", b =>
                {
                    b.Property<string>("TID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TID");

                    b.ToTable("Teacher", (string)null);

                    b.HasData(
                        new
                        {
                            TID = "T001",
                            Password = "T001",
                            TName = "測試教師1"
                        },
                        new
                        {
                            TID = "T002",
                            Password = "T002",
                            TName = "測試教師2"
                        });
                });

            modelBuilder.Entity("LMSweb.Models.Course", b =>
                {
                    b.HasOne("LMSweb.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LMSweb.Models.KnowledgePoint", b =>
                {
                    b.HasOne("LMSweb.Models.Course", "Course")
                        .WithMany("KnowledgePoints")
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("LMSweb.Models.Mission", b =>
                {
                    b.HasOne("LMSweb.Models.Course", "Course")
                        .WithMany("Missions")
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("LMSweb.Models.Student", b =>
                {
                    b.HasOne("LMSweb.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CID");

                    b.HasOne("LMSweb.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GID");

                    b.Navigation("Course");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("LMSweb.Models.Course", b =>
                {
                    b.Navigation("KnowledgePoints");

                    b.Navigation("Missions");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("LMSweb.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("LMSweb.Models.Teacher", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
