﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pharmacy;

namespace Pharmacy.Migrations
{
    [DbContext(typeof(PharmacyDbContext))]
    [Migration("20220105142408_tender3")]
    partial class tender3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Pharmacy.ApiKeys.Model.ApiKey", b =>
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

            modelBuilder.Entity("Pharmacy.ApiKeys.Model.Message", b =>
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

            modelBuilder.Entity("Pharmacy.Feedbacks.Model.Feedback", b =>
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

            modelBuilder.Entity("Pharmacy.Feedbacks.Model.FeedbackReply", b =>
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

            modelBuilder.Entity("Pharmacy.Prescriptions.Model.Medicine", b =>
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

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

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
                            Price = 4.5,
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
                            Price = 5.0,
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
                            Price = 5.25,
                            Quantity = 250,
                            Reactions = "None",
                            SideEffects = "None",
                            Usage = "Toothache, Headache",
                            Weight = 500
                        });
                });

            modelBuilder.Entity("Pharmacy.Tendering.Model.Tender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tenders");
                });

            modelBuilder.Entity("Pharmacy.Tendering.Model.TenderResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsWinningBid")
                        .HasColumnType("boolean");

                    b.Property<string>("PharmacyName")
                        .HasColumnType("text");

                    b.Property<int>("TenderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TenderResponses");
                });

            modelBuilder.Entity("Pharmacy.Tendering.Model.Tender", b =>
                {
                    b.OwnsOne("Pharmacy.Tendering.Model.DateRange", "DateRange", b1 =>
                        {
                            b1.Property<int>("TenderId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.HasKey("TenderId");

                            b1.ToTable("Tenders");

                            b1.WithOwner()
                                .HasForeignKey("TenderId");
                        });

                    b.OwnsMany("Pharmacy.Tendering.Model.TenderItem", "TenderItems", b1 =>
                        {
                            b1.Property<int>("TenderId")
                                .HasColumnType("integer");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("Name")
                                .HasColumnType("text");

                            b1.Property<int>("Quantity")
                                .HasColumnType("integer");

                            b1.HasKey("TenderId", "Id");

                            b1.ToTable("Tenders_TenderItems");

                            b1.WithOwner()
                                .HasForeignKey("TenderId");
                        });

                    b.Navigation("DateRange");

                    b.Navigation("TenderItems");
                });

            modelBuilder.Entity("Pharmacy.Tendering.Model.TenderResponse", b =>
                {
                    b.OwnsOne("Pharmacy.Tendering.Model.Price", "TotalPrice", b1 =>
                        {
                            b1.Property<int>("TenderResponseId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.HasKey("TenderResponseId");

                            b1.ToTable("TenderResponses");

                            b1.WithOwner()
                                .HasForeignKey("TenderResponseId");
                        });

                    b.OwnsMany("Pharmacy.Tendering.Model.TenderItem", "TenderItems", b1 =>
                        {
                            b1.Property<int>("TenderResponseId")
                                .HasColumnType("integer");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b1.Property<string>("Name")
                                .HasColumnType("text");

                            b1.Property<int>("Quantity")
                                .HasColumnType("integer");

                            b1.HasKey("TenderResponseId", "Id");

                            b1.ToTable("TenderResponses_TenderItems");

                            b1.WithOwner()
                                .HasForeignKey("TenderResponseId");
                        });

                    b.Navigation("TenderItems");

                    b.Navigation("TotalPrice");
                });
#pragma warning restore 612, 618
        }
    }
}
