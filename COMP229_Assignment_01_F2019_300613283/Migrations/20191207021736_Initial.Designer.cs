﻿// <auto-generated />
using System;
using COMP229_Assignment_01_F2019_300613283.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace COMP229_Assignment_01_F2019_300613283.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20191207021736_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COMP229_Assignment_01_F2019_300613283.Models.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Amount");

                    b.Property<string>("Name");

                    b.Property<int?>("RecipeID");

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("COMP229_Assignment_01_F2019_300613283.Models.Recipe", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Creator");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("COMP229_Assignment_01_F2019_300613283.Models.Review", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RecipeID");

                    b.Property<string>("RecipeReview");

                    b.HasKey("ID");

                    b.HasIndex("RecipeID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("COMP229_Assignment_01_F2019_300613283.Models.Ingredient", b =>
                {
                    b.HasOne("COMP229_Assignment_01_F2019_300613283.Models.Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeID");
                });

            modelBuilder.Entity("COMP229_Assignment_01_F2019_300613283.Models.Review", b =>
                {
                    b.HasOne("COMP229_Assignment_01_F2019_300613283.Models.Recipe")
                        .WithMany("Reviews")
                        .HasForeignKey("RecipeID");
                });
#pragma warning restore 612, 618
        }
    }
}
