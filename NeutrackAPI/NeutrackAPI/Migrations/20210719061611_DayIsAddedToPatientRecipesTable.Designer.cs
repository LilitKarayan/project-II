﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NeutrackAPI.Data;

namespace NeutrackAPI.Migrations
{
    [DbContext(typeof(NeutrackContext))]
    [Migration("20210719061611_DayIsAddedToPatientRecipesTable")]
    partial class DayIsAddedToPatientRecipesTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NeutrackAPI.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("NutritionistId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("SubmittedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("NutritionistId");

                    b.HasIndex("PatientId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Nutritionist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Nutritionists");
                });

            modelBuilder.Entity("NeutrackAPI.Models.NutritionistPatientHistory", b =>
                {
                    b.Property<int>("NutritionistId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("NutritionistId", "PatientId");

                    b.HasIndex("PatientId");

                    b.ToTable("NutritionistPatientHistories");
                });

            modelBuilder.Entity("NeutrackAPI.Models.NutritionistRate", b =>
                {
                    b.Property<int>("NutritionistId")
                        .HasColumnType("int");

                    b.Property<int>("RateId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("NutritionistId", "RateId");

                    b.HasIndex("RateId");

                    b.ToTable("NutritionistRates");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ActivityLevel")
                        .HasColumnType("int");

                    b.Property<double?>("Goal")
                        .HasColumnType("float");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int?>("NutritionistId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<double?>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("NutritionistId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("NeutrackAPI.Models.PatientActivityHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientActivityHistories");
                });

            modelBuilder.Entity("NeutrackAPI.Models.PatientRecipe", b =>
                {
                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.HasKey("RecipeID", "PatientID");

                    b.HasIndex("PatientID");

                    b.ToTable("PatientRecipes");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("CaloriesPerGram")
                        .HasColumnType("float");

                    b.Property<double>("CarbInGrams")
                        .HasColumnType("float");

                    b.Property<double>("FatInGrams")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProteinInGrams")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Charge")
                        .HasColumnType("float");

                    b.Property<int>("RateTypeId")
                        .HasColumnType("int");

                    b.Property<double>("ServiceChargePercentage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("RateTypeId");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("NeutrackAPI.Models.RateType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("RateTypes");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Instruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("NeutrackAPI.Models.RecipeProduct", b =>
                {
                    b.Property<int>("RecipeID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<double>("WeightInGrams")
                        .HasColumnType("float");

                    b.HasKey("RecipeID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("RecipeProducts");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("NeutrackAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComputedColumnSql("[FirstName] + ' ' + [LastName]");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NeutrackAPI.Models.UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Feedback", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Nutritionist", "Nutritionist")
                        .WithMany("Feedbacks")
                        .HasForeignKey("NutritionistId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NeutrackAPI.Models.Patient", "Patient")
                        .WithMany("Feedbacks")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Nutritionist");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Nutritionist", b =>
                {
                    b.HasOne("NeutrackAPI.Models.User", "User")
                        .WithOne("Nutritionist")
                        .HasForeignKey("NeutrackAPI.Models.Nutritionist", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NeutrackAPI.Models.NutritionistPatientHistory", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Nutritionist", "Nutritionist")
                        .WithMany("NutritionistPatientHistories")
                        .HasForeignKey("NutritionistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeutrackAPI.Models.Patient", "Patient")
                        .WithMany("NutritionistPatientHistories")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutritionist");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("NeutrackAPI.Models.NutritionistRate", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Nutritionist", "Nutritionist")
                        .WithMany("NutritionistRates")
                        .HasForeignKey("NutritionistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeutrackAPI.Models.Rate", "Rate")
                        .WithMany("NutritionistRates")
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutritionist");

                    b.Navigation("Rate");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Patient", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Nutritionist", "Nutritionist")
                        .WithMany("Patients")
                        .HasForeignKey("NutritionistId");

                    b.HasOne("NeutrackAPI.Models.User", "User")
                        .WithOne("Patient")
                        .HasForeignKey("NeutrackAPI.Models.Patient", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Nutritionist");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NeutrackAPI.Models.PatientActivityHistory", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Patient", "Patient")
                        .WithMany("PatientActivityHistories")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("NeutrackAPI.Models.PatientRecipe", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Patient", "Patient")
                        .WithMany("PatientRecipes")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeutrackAPI.Models.Recipe", "Recipe")
                        .WithMany("PatientRecipes")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Rate", b =>
                {
                    b.HasOne("NeutrackAPI.Models.RateType", "RateType")
                        .WithMany("Rates")
                        .HasForeignKey("RateTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RateType");
                });

            modelBuilder.Entity("NeutrackAPI.Models.RecipeProduct", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Product", "Product")
                        .WithMany("RecipeProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeutrackAPI.Models.Recipe", "Recipe")
                        .WithMany("RecipeProducts")
                        .HasForeignKey("RecipeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("NeutrackAPI.Models.UserRole", b =>
                {
                    b.HasOne("NeutrackAPI.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NeutrackAPI.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Nutritionist", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("NutritionistPatientHistories");

                    b.Navigation("NutritionistRates");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Patient", b =>
                {
                    b.Navigation("Feedbacks");

                    b.Navigation("NutritionistPatientHistories");

                    b.Navigation("PatientActivityHistories");

                    b.Navigation("PatientRecipes");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Product", b =>
                {
                    b.Navigation("RecipeProducts");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Rate", b =>
                {
                    b.Navigation("NutritionistRates");
                });

            modelBuilder.Entity("NeutrackAPI.Models.RateType", b =>
                {
                    b.Navigation("Rates");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Recipe", b =>
                {
                    b.Navigation("PatientRecipes");

                    b.Navigation("RecipeProducts");
                });

            modelBuilder.Entity("NeutrackAPI.Models.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("NeutrackAPI.Models.User", b =>
                {
                    b.Navigation("Nutritionist");

                    b.Navigation("Patient");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}