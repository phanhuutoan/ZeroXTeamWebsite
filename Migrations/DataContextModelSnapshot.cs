﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ZeroXTeam.Data;

namespace ZeroXTeam.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MemberProject", b =>
                {
                    b.Property<int>("MemberJoinedId")
                        .HasColumnType("integer");

                    b.Property<int>("ProjectJoinedId")
                        .HasColumnType("integer");

                    b.HasKey("MemberJoinedId", "ProjectJoinedId");

                    b.HasIndex("ProjectJoinedId");

                    b.ToTable("MemberProject");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.AdminAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.ToTable("AdminAccount");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.AppliedPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AboutMe")
                        .HasColumnType("text");

                    b.Property<string>("CvUrl")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<int>("RecruitmentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RecruitmentId");

                    b.ToTable("AppliedPerson");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Brief")
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Views")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("HasRead")
                        .HasColumnType("boolean");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Subject")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.HomePageInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AboutPublicId")
                        .HasColumnType("text");

                    b.Property<string>("AboutUrl")
                        .HasColumnType("text");

                    b.Property<string>("HeroPublicId")
                        .HasColumnType("text");

                    b.Property<string>("HeroUrl")
                        .HasColumnType("text");

                    b.Property<string>("SubTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("HomePageInformation");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Facebook")
                        .HasColumnType("text");

                    b.Property<DateTime>("JoinedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<bool>("ShowForClient")
                        .HasColumnType("boolean");

                    b.Property<string>("TeamTitles")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Page")
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<string>("Repository")
                        .HasColumnType("text");

                    b.Property<bool>("ShowForClient")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.Recruitment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Benefits")
                        .HasColumnType("text");

                    b.Property<string>("ContactWithUs")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Experience")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("LastDay")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("text");

                    b.Property<string>("PublicId")
                        .HasColumnType("text");

                    b.Property<string>("Requirements")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Recruitment");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.UserComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BlogId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("UserComment");
                });

            modelBuilder.Entity("MemberProject", b =>
                {
                    b.HasOne("ZeroXTeam.Entities.Member", null)
                        .WithMany()
                        .HasForeignKey("MemberJoinedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZeroXTeam.Entities.Project", null)
                        .WithMany()
                        .HasForeignKey("ProjectJoinedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ZeroXTeam.Entities.AppliedPerson", b =>
                {
                    b.HasOne("ZeroXTeam.Entities.Recruitment", "Recruitment")
                        .WithMany("AppliedPeople")
                        .HasForeignKey("RecruitmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recruitment");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.UserComment", b =>
                {
                    b.HasOne("ZeroXTeam.Entities.Blog", "Blog")
                        .WithMany("UserComments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.Blog", b =>
                {
                    b.Navigation("UserComments");
                });

            modelBuilder.Entity("ZeroXTeam.Entities.Recruitment", b =>
                {
                    b.Navigation("AppliedPeople");
                });
#pragma warning restore 612, 618
        }
    }
}
