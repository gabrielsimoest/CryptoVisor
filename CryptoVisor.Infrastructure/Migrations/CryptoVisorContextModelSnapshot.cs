﻿// <auto-generated />
using System;
using CryptoVisor.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CryptoVisor.Infrastructure.Migrations
{
    [DbContext(typeof(CryptoVisorContext))]
    partial class CryptoVisorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("CryptoVisor.Core.Entities.OhclCoinHistory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Close")
                        .HasColumnType("REAL");

                    b.Property<int>("CoinType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<double>("High")
                        .HasColumnType("REAL");

                    b.Property<double>("Low")
                        .HasColumnType("REAL");

                    b.Property<double>("Open")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("OhclCoinHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
