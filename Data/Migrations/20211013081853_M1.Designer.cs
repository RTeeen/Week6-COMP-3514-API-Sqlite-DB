﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Week6ind.Data;

namespace Week6ind.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211013081853_M1")]
    partial class M1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Population")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.HasIndex("ProvinceCode");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Province", b =>
                {
                    b.Property<string>("ProvinceCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProvinceCode");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.HasOne("Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceCode");

                    b.Navigation("Province");
                });

            modelBuilder.Entity("Province", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}