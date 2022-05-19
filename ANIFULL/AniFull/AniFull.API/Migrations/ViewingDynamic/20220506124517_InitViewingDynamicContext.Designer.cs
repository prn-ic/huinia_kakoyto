﻿// <auto-generated />
using System;
using AniFull.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AniFull.API.Migrations.ViewingDynamic
{
    [DbContext(typeof(ViewingDynamicContext))]
    [Migration("20220506124517_InitViewingDynamicContext")]
    partial class InitViewingDynamicContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("AniFull.API.Models.ViewingDynamic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastWatched")
                        .HasColumnType("TEXT");

                    b.Property<int>("Series")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ViewingDynamics");
                });
#pragma warning restore 612, 618
        }
    }
}