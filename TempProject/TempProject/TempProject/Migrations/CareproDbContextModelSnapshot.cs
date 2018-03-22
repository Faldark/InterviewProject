﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TempProject.Data.Enums;
using TempProject.Data.MSSQL;

namespace TempProject.Migrations
{
    [DbContext(typeof(CareproDbContext))]
    partial class CareproDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TempProject.Data.Entities.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AboutMe");

                    b.HasKey("Id");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("TempProject.Data.Entities.PersonalInformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("DetaOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("PersonalInformations");
                });

            modelBuilder.Entity("TempProject.Data.Entities.Pricing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("Pricings");
                });

            modelBuilder.Entity("TempProject.Data.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ScheduledTime");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("TempProject.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AboutId");

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int?>("PersonalInformationId");

                    b.Property<int?>("PricingId");

                    b.Property<int?>("ScheduleId");

                    b.Property<int?>("WorkAbilitiesId");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.HasIndex("PersonalInformationId");

                    b.HasIndex("PricingId");

                    b.HasIndex("ScheduleId");

                    b.HasIndex("WorkAbilitiesId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TempProject.Data.Entities.WorkAbilities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abilities");

                    b.HasKey("Id");

                    b.ToTable("WorkAbilities");
                });

            modelBuilder.Entity("TempProject.Data.Entities.User", b =>
                {
                    b.HasOne("TempProject.Data.Entities.About", "About")
                        .WithMany()
                        .HasForeignKey("AboutId");

                    b.HasOne("TempProject.Data.Entities.PersonalInformation", "PersonalInformation")
                        .WithMany()
                        .HasForeignKey("PersonalInformationId");

                    b.HasOne("TempProject.Data.Entities.Pricing", "Pricing")
                        .WithMany()
                        .HasForeignKey("PricingId");

                    b.HasOne("TempProject.Data.Entities.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleId");

                    b.HasOne("TempProject.Data.Entities.WorkAbilities", "WorkAbilities")
                        .WithMany()
                        .HasForeignKey("WorkAbilitiesId");
                });
#pragma warning restore 612, 618
        }
    }
}
