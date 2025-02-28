﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pharmacy;

namespace Pharmacy.Migrations
{
    [DbContext(typeof(PharmacyDbContext))]
    partial class PharmacyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Pharmacy.Model.ApiKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("BaseUrl")
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("Pharmacy.Model.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ReceiverId")
                        .HasColumnType("integer");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeOfSending")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Pharmacy.Model.FeedbackReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("FeedbackId")
                        .HasColumnType("integer");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("integer");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<DateTime>("TimeOfSending")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("FeedbackReplies");
                });

            modelBuilder.Entity("Pharmacy.Model.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CompatibileMedicine")
                        .HasColumnType("text");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<string>("Reactions")
                        .HasColumnType("text");

                    b.Property<string>("SideEffects")
                        .HasColumnType("text");

                    b.Property<string>("Usage")
                        .HasColumnType("text");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Medicines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompatibileMedicine = "Aspirin",
                            Manufacturer = "Bayer",
                            Name = "Brufen",
                            Quantity = 400,
                            Reactions = "Headache",
                            SideEffects = "Rash, Stomach pain",
                            Usage = "Pain relief",
                            Weight = 400
                        },
                        new
                        {
                            Id = 2,
                            CompatibileMedicine = "Aspirin",
                            Manufacturer = "Bayer",
                            Name = "Klacid",
                            Quantity = 200,
                            Reactions = "Headache, Swelling",
                            SideEffects = "Rash, Unconsciousness",
                            Usage = "Lung infections, Bronchitis",
                            Weight = 500
                        },
                        new
                        {
                            Id = 3,
                            CompatibileMedicine = "Aspirin",
                            Manufacturer = "Galenika",
                            Name = "Paracetamol",
                            Quantity = 250,
                            Reactions = "None",
                            SideEffects = "None",
                            Usage = "Toothache, Headache",
                            Weight = 500
                        });
                });

            modelBuilder.Entity("Pharmacy.Model.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("MessageText")
                        .HasColumnType("text");

                    b.Property<string>("Receiver")
                        .HasColumnType("text");

                    b.Property<string>("Sender")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
