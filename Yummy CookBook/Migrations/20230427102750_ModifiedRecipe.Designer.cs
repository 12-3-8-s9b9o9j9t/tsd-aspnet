﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Yummy_CookBook.Data;

#nullable disable

namespace Yummy_CookBook.Migrations
{
    [DbContext(typeof(YummyContext))]
    [Migration("20230427102750_ModifiedRecipe")]
    partial class ModifiedRecipe
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Yummy_CookBook.Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("NbLikes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Process")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<uint>("Time")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipsTricks")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}