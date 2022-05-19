﻿// <auto-generated />
using System;
using AniFull.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AniFull.API.Migrations.RecentlyViewed
{
    [DbContext(typeof(RecentlyViewedContext))]
    partial class RecentlyViewedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("AniFull.API.Models.RecentlyView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("LastViewed")
                        .HasColumnType("TEXT");

                    b.Property<int>("Series")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VideoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("RecentlyViews");
                });
#pragma warning restore 612, 618
        }
    }
}