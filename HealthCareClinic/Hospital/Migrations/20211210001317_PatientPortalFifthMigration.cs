﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Hospital.Migrations
{
    public partial class PatientPortalFifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allergens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allergens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false),
                    isCancelled = table.Column<bool>(type: "boolean", nullable: false),
                    isDone = table.Column<bool>(type: "boolean", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SurveyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    X = table.Column<float>(type: "real", nullable: false),
                    Y = table.Column<float>(type: "real", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CanceledAppointments",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    DateOfCancellation = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanceledAppointments", x => new { x.PatientId, x.AppointmentId });
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WorkShift = table.Column<int>(type: "integer", nullable: false),
                    Specialty = table.Column<string>(type: "text", nullable: true),
                    PrimaryRoom = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Salary = table.Column<double>(type: "double precision", nullable: false),
                    EmploymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    RoomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    IsAnonymous = table.Column<bool>(type: "boolean", nullable: false),
                    Identity = table.Column<string>(type: "text", nullable: true),
                    CanBePublished = table.Column<bool>(type: "boolean", nullable: false),
                    IsPublished = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackMessages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    BuildingId = table.Column<int>(type: "integer", nullable: false),
                    X = table.Column<float>(type: "real", nullable: false),
                    Y = table.Column<float>(type: "real", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Renovations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstRoomId = table.Column<int>(type: "integer", nullable: false),
                    SecondRoomId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renovations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    FloorId = table.Column<int>(type: "integer", nullable: false),
                    X = table.Column<float>(type: "real", nullable: false),
                    Y = table.Column<float>(type: "real", nullable: false),
                    Width = table.Column<float>(type: "real", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transfer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Equipment = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    SourceRoomId = table.Column<int>(type: "integer", nullable: false),
                    DestinationRoomId = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Duration = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AppointmentId = table.Column<int>(type: "integer", nullable: false),
                    Done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Surveys_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    DayId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Spec_Day = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.DayId);
                    table.ForeignKey(
                        name: "FK_Day_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ParentName = table.Column<string>(type: "text", nullable: true),
                    DateOfRegistration = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsBlocked = table.Column<bool>(type: "boolean", nullable: false),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    BloodType = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Username = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    EmploymentStatus = table.Column<string>(type: "text", nullable: true),
                    Hashcode = table.Column<string>(type: "text", nullable: true),
                    DoctorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Day = table.Column<int>(type: "integer", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DoctorId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkDay_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurveyCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SurveyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyCategories_Surveys_SurveyId",
                        column: x => x.SurveyId,
                        principalTable: "Surveys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllergenForPatients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "integer", nullable: false),
                    AllergenId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergenForPatients", x => new { x.PatientId, x.AllergenId });
                    table.ForeignKey(
                        name: "FK_AllergenForPatients_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Diagnosis = table.Column<string>(type: "text", nullable: true),
                    Medicine = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    PatientId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Grade = table.Column<int>(type: "integer", nullable: false),
                    SurveyCategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurveyQuestions_SurveyCategories_SurveyCategoryId",
                        column: x => x.SurveyCategoryId,
                        principalTable: "SurveyCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Allergens",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "Školjke" },
                    { 8, "Kravlje mleko" },
                    { 7, "Kikiriki" },
                    { 6, "Lateks" },
                    { 5, "Mačija dlaka" },
                    { 9, "Jaja" },
                    { 3, "Aspirin" },
                    { 2, "Ibuprofen" },
                    { 1, "Polen ambrozije" },
                    { 4, "Penicilin" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "DoctorId", "PatientId", "RoomId", "SurveyId", "isCancelled", "isDone" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 2, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, 1, 3, false, false },
                    { 1, new DateTime(2022, 2, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 1, false, false },
                    { 10, new DateTime(2021, 2, 22, 11, 30, 0, 0, DateTimeKind.Unspecified), 2, 1, 2, 10, false, true },
                    { 9, new DateTime(2022, 2, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, 1, 9, false, false },
                    { 8, new DateTime(2022, 2, 22, 10, 30, 0, 0, DateTimeKind.Unspecified), 1, 8, 1, 8, false, false },
                    { 7, new DateTime(2022, 2, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 7, 1, 7, false, false },
                    { 6, new DateTime(2022, 2, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 1, 6, 1, 6, false, false },
                    { 5, new DateTime(2022, 2, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, 1, 5, false, false },
                    { 4, new DateTime(2022, 2, 22, 8, 30, 0, 0, DateTimeKind.Unspecified), 1, 4, 1, 4, false, false },
                    { 2, new DateTime(2022, 2, 22, 7, 30, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, 2, false, false }
                });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Height", "Name", "Type", "Width", "X", "Y" },
                values: new object[,]
                {
                    { 1, 140f, "Building1", 0, 400f, 260f, 30f },
                    { 7, 70f, "Parking3", 1, 200f, 800f, 130f },
                    { 6, 70f, "Parking2", 1, 200f, 800f, 30f },
                    { 5, 70f, "Parking1", 1, 200f, 30f, 30f },
                    { 4, 140f, "Building4", 0, 300f, 700f, 230f },
                    { 3, 240f, "Building3", 0, 180f, 30f, 130f },
                    { 2, 140f, "Building2", 0, 400f, 260f, 230f }
                });

            migrationBuilder.InsertData(
                table: "CanceledAppointments",
                columns: new[] { "AppointmentId", "PatientId", "DateOfCancellation" },
                values: new object[,]
                {
                    { 1764, 1, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1765, 1, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1763, 1, new DateTime(2021, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1766, 1, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1777, 1, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1767, 16, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1768, 16, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1870, 1, new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1799, 2, new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1780, 16, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1769, 16, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Address", "BirthDate", "Email", "EmploymentDate", "Gender", "Name", "Password", "Phone", "PrimaryRoom", "Salary", "Specialty", "Surname", "Username", "WorkShift" },
                values: new object[,]
                {
                    { 1, "Brace Radica 15", new DateTime(1981, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "nikolanikolic@gmail.com", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "Nikola", "nikola", "0697856665", 1, 80000.0, "General medicine", "Nikolic", "nikola", 0 },
                    { 4, "Mike Antice 5", new DateTime(1968, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "dragana@gmail.com", new DateTime(2017, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "female", "Dragana", "dragana", "0697856665", 4, 80000.0, "Surgery", "Zoric", "dragana", 1 },
                    { 3, "Bulevar Oslobodjenja 5", new DateTime(1986, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "jozika@gmail.com", new DateTime(2011, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "Jozef", "jozef", "0697856665", 3, 80000.0, "General medicine", "Sivc", "jozef", 0 },
                    { 2, "Bogoboja Atanackovica 5", new DateTime(1986, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "markoradic@gmail.com", new DateTime(2020, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "Marko", "marko", "0697856665", 2, 80000.0, "General medicine", "Radic", "marko", 0 },
                    { 5, "Pariske Komune 35", new DateTime(1978, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "mile@gmail.com", new DateTime(2007, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "Mile", "mile", "0697856665", 5, 80000.0, "Surgery", "Grandic", "mile", 1 },
                    { 6, "Pariske Komune 85", new DateTime(1968, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "misa@gmail.com", new DateTime(2006, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "male", "Misa", "misa", "0697856665", 6, 80000.0, "General medicine", "Bradina", "misa", 1 }
                });

            migrationBuilder.InsertData(
                table: "Equipments",
                columns: new[] { "Id", "Name", "Quantity", "RoomId", "Type" },
                values: new object[,]
                {
                    { 38, "TV", 3, 45, 0 },
                    { 6, "Bed", 2, 2, 0 },
                    { 7, "Needle", 3, 2, 1 },
                    { 8, "TV", 3, 4, 0 },
                    { 9, "Bandage", 5, 4, 1 },
                    { 10, "Blanket", 2, 4, 0 },
                    { 11, "Bed", 25, 8, 0 },
                    { 12, "Needle", 3, 9, 1 },
                    { 14, "Bandage", 6, 11, 1 },
                    { 15, "Blanket", 5, 11, 0 },
                    { 16, "Bed", 26, 15, 0 },
                    { 17, "Needle", 23, 17, 1 },
                    { 18, "TV", 1, 17, 0 },
                    { 19, "Bandage", 120, 17, 1 },
                    { 20, "Blanket", 52, 18, 0 },
                    { 21, "Bed", 1, 20, 0 },
                    { 22, "Needle", 1, 22, 1 },
                    { 36, "Bed", 9, 43, 0 },
                    { 37, "Needle", 9, 43, 1 },
                    { 35, "Blanket", 9, 40, 0 },
                    { 34, "Bandage", 1, 40, 1 },
                    { 33, "TV", 3, 40, 0 },
                    { 32, "Needle", 4, 36, 1 },
                    { 31, "Bed", 7, 36, 0 },
                    { 5, "Blanket", 5, 1, 0 },
                    { 30, "Blanket", 4, 30, 0 },
                    { 28, "TV", 2, 29, 0 },
                    { 27, "Needle", 2, 26, 1 },
                    { 26, "Bed", 3, 26, 0 },
                    { 25, "Blanket", 1, 23, 0 },
                    { 24, "Bandage", 1, 23, 1 },
                    { 23, "TV", 1, 22, 0 },
                    { 29, "Bandage", 4, 30, 1 },
                    { 4, "Bandage", 10, 1, 1 },
                    { 13, "TV", 4, 9, 0 },
                    { 2, "Needle", 25, 1, 1 },
                    { 3, "TV", 1, 1, 0 },
                    { 51, "Bed", 17, 65, 0 },
                    { 52, "Needle", 17, 66, 1 },
                    { 53, "TV", 2, 68, 0 },
                    { 54, "Bandage", 17, 69, 1 },
                    { 55, "Blanket", 17, 69, 0 },
                    { 50, "Blanket", 13, 65, 0 },
                    { 49, "Bandage", 13, 62, 1 },
                    { 47, "Needle", 13, 60, 1 },
                    { 48, "TV", 2, 62, 0 },
                    { 45, "Blanket", 15, 55, 0 },
                    { 44, "Bandage", 11, 55, 1 },
                    { 43, "TV", 1, 52, 0 },
                    { 42, "Needle", 4, 51, 1 },
                    { 41, "Bed", 7, 50, 0 },
                    { 40, "Blanket", 9, 47, 0 },
                    { 39, "Bandage", 9, 47, 1 },
                    { 1, "Bed", 5, 1, 0 },
                    { 46, "Bed", 13, 60, 0 }
                });

            migrationBuilder.InsertData(
                table: "FeedbackMessages",
                columns: new[] { "Id", "CanBePublished", "Date", "Identity", "IsAnonymous", "IsPublished", "Text" },
                values: new object[,]
                {
                    { 4, true, new DateTime(2021, 5, 20, 9, 10, 21, 0, DateTimeKind.Unspecified), "UrosDevic0", false, false, "Odlični lekari." },
                    { 1, true, new DateTime(2021, 4, 29, 18, 34, 21, 0, DateTimeKind.Unspecified), "acaNikolic", false, false, "Zadovoljan sam uslugom." },
                    { 2, true, new DateTime(2021, 6, 21, 14, 21, 56, 0, DateTimeKind.Unspecified), "NikolaTodorovic94", true, false, "Čekanje je moglo biti kraće." },
                    { 5, true, new DateTime(2021, 9, 30, 7, 50, 19, 0, DateTimeKind.Unspecified), "MladenAlicic1", false, true, "Savremena bolnica koju bih preporučio ljudima." },
                    { 3, false, new DateTime(2021, 2, 16, 11, 8, 47, 0, DateTimeKind.Unspecified), "MarijaPopovic", false, false, "Informacionom sistemu potrebne su određene popravke." },
                    { 7, true, new DateTime(2021, 9, 30, 7, 50, 19, 0, DateTimeKind.Unspecified), "JovanaGugl", false, true, "Savremena bolnica koju bih preporučio ljudima." },
                    { 8, true, new DateTime(2021, 9, 30, 7, 50, 19, 0, DateTimeKind.Unspecified), "RatkoVarda8", false, true, "Savremena bolnica koju bih preporučio ljudima." },
                    { 6, true, new DateTime(2021, 9, 30, 7, 50, 19, 0, DateTimeKind.Unspecified), "IvanJovanovic", false, true, "Savremena bolnica koju bih preporučio ljudima." }
                });

            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "Id", "BuildingId", "Height", "Name", "Width", "X", "Y" },
                values: new object[,]
                {
                    { 1, 1, 0f, "Floor 1", 0f, 0f, 0f },
                    { 2, 1, 0f, "Floor 2", 0f, 0f, 0f },
                    { 3, 1, 0f, "Floor 3", 0f, 0f, 0f },
                    { 4, 2, 0f, "Floor 1", 0f, 0f, 0f },
                    { 5, 2, 0f, "Floor 2", 0f, 0f, 0f },
                    { 6, 3, 0f, "Floor 1", 0f, 0f, 0f },
                    { 7, 3, 0f, "Floor 2", 0f, 0f, 0f },
                    { 8, 3, 0f, "Floor 3", 0f, 0f, 0f },
                    { 9, 4, 0f, "Floor 1", 0f, 0f, 0f },
                    { 10, 4, 0f, "Floor 2", 0f, 0f, 0f }
                });

            migrationBuilder.InsertData(
                table: "Renovations",
                columns: new[] { "Id", "Date", "Duration", "FirstRoomId", "SecondRoomId", "Type" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 2, 20, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 47, 62, 1 },
                    { 1, new DateTime(2022, 2, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, 2, 1 },
                    { 2, new DateTime(2022, 2, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, 1, 0, 0 }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "FloorId", "Height", "Name", "Type", "Width", "X", "Y" },
                values: new object[,]
                {
                    { 60, "Room description...", 9, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 70, "Room description...", 10, 90f, "WC", 2, 150f, 50f, 170f },
                    { 69, "Room description...", 10, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 68, "Room description...", 10, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 67, "Room description...", 10, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 66, "Room description...", 10, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 65, "Room description...", 10, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 64, "Room description...", 10, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 63, "Room description...", 9, 90f, "WC", 2, 150f, 50f, 170f },
                    { 62, "Room description...", 9, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 61, "Room description...", 9, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 59, "Room description...", 9, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 45, "Room description...", 7, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 57, "Room description...", 9, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 29, "Room description...", 5, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 28, "Room description...", 4, 90f, "WC", 2, 150f, 50f, 170f },
                    { 27, "Room description...", 4, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 26, "Room description...", 4, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 25, "Room description...", 4, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 24, "Room description...", 4, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 22, "Room description...", 4, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 21, "Room description...", 3, 90f, "WC", 2, 150f, 50f, 170f },
                    { 20, "Room description...", 3, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 19, "Room description...", 3, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 18, "Room description...", 3, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 17, "Room description...", 3, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 16, "Room description...", 3, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 30, "Room description...", 5, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 15, "Room description...", 3, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 13, "Room description...", 2, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 12, "Room description...", 2, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 11, "Room description...", 2, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 10, "Room description...", 2, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 9, "Room description...", 2, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 8, "Room description...", 2, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 7, "Room description...", 1, 90f, "WC", 2, 150f, 50f, 170f },
                    { 6, "Room description...", 1, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 5, "Room description...", 1, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 4, "Room description...", 1, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 3, "Room description...", 1, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 2, "Room description...", 1, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 1, "Room description...", 1, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 14, "Room description...", 2, 90f, "WC", 2, 150f, 50f, 170f },
                    { 58, "Room description...", 9, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 31, "Room description...", 5, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 33, "Room description...", 5, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 56, "Room description...", 8, 90f, "WC", 2, 150f, 50f, 170f },
                    { 55, "Room description...", 8, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 54, "Room description...", 8, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 53, "Room description...", 8, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 52, "Room description...", 8, 140f, "Room for appointments", 0, 270f, 50f, 260f },
                    { 51, "Room description...", 8, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 50, "Room description...", 8, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 49, "Room description...", 7, 90f, "WC", 2, 150f, 50f, 170f },
                    { 48, "Room description...", 7, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 47, "Room description...", 7, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 46, "Room description...", 7, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 32, "Room description...", 5, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 23, "Room description...", 4, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 40, "Room description...", 6, 140f, "Room for appointments", 0, 270f, 50f, 30f },
                    { 34, "Room description...", 5, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 35, "Room description...", 5, 90f, "WC", 2, 150f, 50f, 170f },
                    { 36, "Room description...", 6, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 44, "Room description...", 7, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 43, "Room description...", 7, 140f, "Operation room", 1, 400f, 320f, 30f },
                    { 42, "Room description...", 6, 90f, "WC", 2, 150f, 50f, 170f },
                    { 41, "Room description...", 6, 140f, "Room for appointments", 0, 280f, 720f, 30f },
                    { 37, "Room description...", 6, 140f, "Room for appointments", 0, 380f, 320f, 260f },
                    { 39, "Room description...", 6, 140f, "Room for appointments", 0, 300f, 700f, 260f },
                    { 38, "Room description...", 6, 140f, "Room for appointments", 0, 270f, 50f, 260f }
                });

            migrationBuilder.InsertData(
                table: "Transfer",
                columns: new[] { "Id", "Date", "DestinationRoomId", "Duration", "Equipment", "Quantity", "SourceRoomId" },
                values: new object[,]
                {
                    { 3, new DateTime(2021, 11, 24, 10, 0, 0, 0, DateTimeKind.Unspecified), 52, 45, "TV", 1, 45 },
                    { 1, new DateTime(2021, 11, 25, 9, 30, 0, 0, DateTimeKind.Unspecified), 2, 60, "Bed", 2, 1 },
                    { 6, new DateTime(2022, 8, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 51, 60, "Needle", 5, 1 },
                    { 5, new DateTime(2021, 11, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), 23, 15, "Blanket", 10, 18 },
                    { 4, new DateTime(2021, 11, 24, 9, 30, 0, 0, DateTimeKind.Unspecified), 62, 15, "Bandage", 4, 47 },
                    { 2, new DateTime(2021, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, 45, "Bed", 4, 50 }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "BirthDate", "BloodType", "DateOfRegistration", "DoctorId", "Email", "EmploymentStatus", "Gender", "Hashcode", "IsActive", "IsBlocked", "Name", "ParentName", "Password", "Phone", "Surname", "Username" },
                values: new object[,]
                {
                    { 8, "Kralja Petra 19", new DateTime(1987, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "B", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "zorka@gmail.com", "Unemployed", "female", null, true, false, "Zorka", "zorka", "zorka", "0697856665", "Djokic", "zorka" },
                    { 6, "Voje Rodica 19", new DateTime(1975, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "miki@gmail.com", "Employed", "male", null, true, false, "Predrag", "miki", "miki", "0697856665", "Zaric", "miki" },
                    { 5, "Voje Rodica 19", new DateTime(1936, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "miki@gmail.com", "Employed", "male", null, true, false, "Igor", "miki", "miki", "0697856665", "Caric", "miki" },
                    { 4, "Voje Rodica 19", new DateTime(1969, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "miki@gmail.com", "Employed", "male", null, true, false, "Milica", "miki", "miki", "0697856665", "Maric", "miki" },
                    { 3, "Voje Rodica 19", new DateTime(1978, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "miki@gmail.com", "Employed", "male", null, true, false, "Zorana", "miki", "miki", "0697856665", "Bilic", "miki" },
                    { 2, "Voje Rodica 19", new DateTime(1985, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "miki@gmail.com", "Employed", "male", null, true, false, "Jovan", "miki", "miki", "0697856665", "Zoric", "miki" },
                    { 1, "Bogoboja Atanackovica 15", new DateTime(2005, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "petar@gmail.com", "Employed", "male", null, true, false, "Petar", "miki", "petar", "0634556665", "Petrovic", "petar" },
                    { 7, "Voje Rodica 19", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "A", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "miki@gmail.com", "Employed", "male", null, true, false, "Miki", "miki", "miki", "0697856665", "Nikolic", "miki" }
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "Id", "AppointmentId", "Done" },
                values: new object[,]
                {
                    { 10, 10, true },
                    { 9, 9, false },
                    { 7, 7, false },
                    { 6, 6, false },
                    { 5, 5, false },
                    { 4, 4, false },
                    { 3, 3, false },
                    { 2, 2, false },
                    { 8, 8, false },
                    { 1, 1, false }
                });

            migrationBuilder.InsertData(
                table: "SurveyCategories",
                columns: new[] { "Id", "Name", "SurveyId" },
                values: new object[,]
                {
                    { 1, "Doctor", 1 },
                    { 28, "Doctor", 10 },
                    { 27, "Hospital", 9 },
                    { 26, "Medical stuff", 9 },
                    { 25, "Doctor", 9 },
                    { 24, "Hospital", 8 },
                    { 23, "Medical stuff", 8 },
                    { 22, "Doctor", 8 },
                    { 21, "Hospital", 7 },
                    { 20, "Medical stuff", 7 },
                    { 19, "Doctor", 7 },
                    { 18, "Hospital", 6 },
                    { 17, "Medical stuff", 6 },
                    { 16, "Doctor", 6 },
                    { 15, "Hospital", 5 },
                    { 14, "Medical stuff", 5 },
                    { 13, "Doctor", 5 },
                    { 12, "Hospital", 4 },
                    { 11, "Medical stuff", 4 },
                    { 10, "Doctor", 4 },
                    { 9, "Hospital", 3 },
                    { 8, "Medical stuff", 3 },
                    { 7, "Doctor", 3 },
                    { 6, "Hospital", 2 },
                    { 5, "Medical stuff", 2 },
                    { 4, "Doctor", 2 },
                    { 3, "Hospital", 1 },
                    { 2, "Medical stuff", 1 },
                    { 29, "Medical stuff", 10 },
                    { 30, "Hospital", 10 }
                });

            migrationBuilder.InsertData(
                table: "SurveyQuestions",
                columns: new[] { "Id", "Content", "Grade", "SurveyCategoryId" },
                values: new object[,]
                {
                    { 1, "How careful did doctor listen you?", 0, 1 },
                    { 97, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 20 },
                    { 98, "How prepared were stuff for emergency situations?", 0, 20 },
                    { 99, "How good has stuff explained you our procedures?", 0, 20 },
                    { 100, "Your general grade for medical stuffs' service", 0, 20 },
                    { 101, "How would you rate our appointment organisation?", 0, 21 },
                    { 102, "How would you rate hospitals' hygiene?", 0, 21 },
                    { 96, "How much our medical staff were polite?", 0, 20 },
                    { 103, "How good were procedure for booking appointment?", 0, 21 },
                    { 105, "Your general grade for whole hospital' service", 0, 21 },
                    { 106, "How careful did doctor listen you?", 0, 22 },
                    { 107, "Has doctor been polite?", 0, 22 },
                    { 108, "Has he explained you your condition enough that you can understand it?", 0, 22 },
                    { 109, "How would you rate doctors' professionalism?", 0, 22 },
                    { 110, "Your general grade for doctors' service", 0, 22 },
                    { 104, "How easy was to use our application?", 0, 21 },
                    { 95, "Your general grade for doctors' service", 0, 19 },
                    { 94, "How would you rate doctors' professionalism?", 0, 19 },
                    { 93, "Has he explained you your condition enough that you can understand it?", 0, 19 },
                    { 78, "Has he explained you your condition enough that you can understand it?", 0, 16 },
                    { 79, "How would you rate doctors' professionalism?", 0, 16 },
                    { 80, "Your general grade for doctors' service", 0, 16 },
                    { 81, "How much our medical staff were polite?", 0, 17 },
                    { 82, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 17 },
                    { 83, "How prepared were stuff for emergency situations?", 0, 17 },
                    { 84, "How good has stuff explained you our procedures?", 0, 17 },
                    { 85, "Your general grade for medical stuffs' service", 0, 17 },
                    { 86, "How would you rate our appointment organisation?", 0, 18 },
                    { 87, "How would you rate hospitals' hygiene?", 0, 18 },
                    { 88, "How good were procedure for booking appointment?", 0, 18 },
                    { 89, "How easy was to use our application?", 0, 18 },
                    { 90, "Your general grade for whole hospital' service", 0, 18 },
                    { 91, "How careful did doctor listen you?", 0, 19 },
                    { 92, "Has doctor been polite?", 0, 19 },
                    { 111, "How much our medical staff were polite?", 0, 23 },
                    { 112, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 23 },
                    { 113, "How prepared were stuff for emergency situations?", 0, 23 },
                    { 114, "How good has stuff explained you our procedures?", 0, 23 },
                    { 134, "How easy was to use our application?", 0, 27 },
                    { 135, "Your general grade for whole hospital' service", 0, 27 },
                    { 136, "How careful did doctor listen you?", 1, 28 },
                    { 137, "Has doctor been polite?", 3, 28 },
                    { 138, "Has he explained you your condition enough that you can understand it?", 4, 28 },
                    { 139, "How would you rate doctors' professionalism?", 5, 28 },
                    { 140, "Your general grade for doctors' service", 3, 28 },
                    { 141, "How much our medical staff were polite?", 2, 29 },
                    { 142, "How would you rate time span that you spend waiting untill doctor attended you?", 3, 29 },
                    { 143, "How prepared were stuff for emergency situations?", 4, 29 },
                    { 144, "How good has stuff explained you our procedures?", 5, 29 },
                    { 145, "Your general grade for medical stuffs' service", 3, 29 },
                    { 146, "How would you rate our appointment organisation?", 1, 30 },
                    { 147, "How would you rate hospitals' hygiene?", 4, 30 },
                    { 148, "How good were procedure for booking appointment?", 4, 30 },
                    { 133, "How good were procedure for booking appointment?", 0, 27 },
                    { 77, "Has doctor been polite?", 0, 16 },
                    { 132, "How would you rate hospitals' hygiene?", 0, 27 },
                    { 130, "Your general grade for medical stuffs' service", 0, 26 },
                    { 115, "Your general grade for medical stuffs' service", 0, 23 },
                    { 116, "How would you rate our appointment organisation?", 0, 24 },
                    { 117, "How would you rate hospitals' hygiene?", 0, 24 },
                    { 118, "How good were procedure for booking appointment?", 0, 24 },
                    { 119, "How easy was to use our application?", 0, 24 },
                    { 120, "Your general grade for whole hospital' service", 0, 24 },
                    { 121, "How careful did doctor listen you?", 0, 25 },
                    { 122, "Has doctor been polite?", 0, 25 },
                    { 123, "Has he explained you your condition enough that you can understand it?", 0, 25 },
                    { 124, "How would you rate doctors' professionalism?", 0, 25 },
                    { 125, "Your general grade for doctors' service", 0, 25 },
                    { 126, "How much our medical staff were polite?", 0, 26 },
                    { 127, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 26 },
                    { 128, "How prepared were stuff for emergency situations?", 0, 26 },
                    { 129, "How good has stuff explained you our procedures?", 0, 26 },
                    { 131, "How would you rate our appointment organisation?", 0, 27 },
                    { 76, "How careful did doctor listen you?", 0, 16 },
                    { 75, "Your general grade for whole hospital' service", 0, 15 },
                    { 74, "How easy was to use our application?", 0, 15 },
                    { 21, "How much our medical staff were polite?", 0, 5 },
                    { 22, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 5 },
                    { 23, "How prepared were stuff for emergency situations?", 0, 5 },
                    { 24, "How good has stuff explained you our procedures?", 0, 5 },
                    { 25, "Your general grade for medical stuffs' service", 0, 5 },
                    { 26, "How would you rate our appointment organisation?", 0, 6 },
                    { 27, "How would you rate hospitals' hygiene?", 0, 6 },
                    { 28, "How good were procedure for booking appointment?", 0, 6 },
                    { 29, "How easy was to use our application?", 0, 6 },
                    { 30, "Your general grade for whole hospital' service", 0, 6 },
                    { 31, "How careful did doctor listen you?", 0, 7 },
                    { 32, "Has doctor been polite?", 0, 7 },
                    { 33, "Has he explained you your condition enough that you can understand it?", 0, 7 },
                    { 34, "How would you rate doctors' professionalism?", 0, 7 },
                    { 35, "Your general grade for doctors' service", 0, 7 },
                    { 20, "Your general grade for doctors' service", 0, 4 },
                    { 36, "How much our medical staff were polite?", 0, 8 },
                    { 19, "How would you rate doctors' professionalism?", 0, 4 },
                    { 17, "Has doctor been polite?", 0, 4 },
                    { 2, "Has doctor been polite?", 0, 1 },
                    { 3, "Has he explained you your condition enough that you can understand it?", 0, 1 },
                    { 4, "How would you rate doctors' professionalism?", 0, 1 },
                    { 5, "Your general grade for doctors' service", 0, 1 },
                    { 6, "How much our medical staff were polite?", 0, 2 },
                    { 7, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 2 },
                    { 8, "How prepared were stuff for emergency situations?", 0, 2 },
                    { 9, "How good has stuff explained you our procedures?", 0, 2 },
                    { 10, "Your general grade for medical stuffs' service", 0, 2 },
                    { 11, "How would you rate our appointment organisation?", 0, 3 },
                    { 12, "How would you rate hospitals' hygiene?", 0, 3 },
                    { 13, "How good were procedure for booking appointment?", 0, 3 },
                    { 14, "How easy was to use our application?", 0, 3 },
                    { 15, "Your general grade for whole hospital' service", 0, 3 },
                    { 16, "How careful did doctor listen you?", 0, 4 },
                    { 18, "Has he explained you your condition enough that you can understand it?", 0, 4 },
                    { 149, "How easy was to use our application?", 5, 30 },
                    { 37, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 8 },
                    { 39, "How good has stuff explained you our procedures?", 0, 8 },
                    { 59, "How easy was to use our application?", 0, 12 },
                    { 60, "Your general grade for whole hospital' service", 0, 12 },
                    { 61, "How careful did doctor listen you?", 0, 13 },
                    { 62, "Has doctor been polite?", 0, 13 },
                    { 63, "Has he explained you your condition enough that you can understand it?", 0, 13 },
                    { 64, "How would you rate doctors' professionalism?", 0, 13 },
                    { 65, "Your general grade for doctors' service", 0, 13 },
                    { 66, "How much our medical staff were polite?", 0, 14 },
                    { 67, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 14 },
                    { 68, "How prepared were stuff for emergency situations?", 0, 14 },
                    { 69, "How good has stuff explained you our procedures?", 0, 14 },
                    { 70, "Your general grade for medical stuffs' service", 0, 14 },
                    { 71, "How would you rate our appointment organisation?", 0, 15 },
                    { 72, "How would you rate hospitals' hygiene?", 0, 15 },
                    { 73, "How good were procedure for booking appointment?", 0, 15 },
                    { 58, "How good were procedure for booking appointment?", 0, 12 },
                    { 38, "How prepared were stuff for emergency situations?", 0, 8 },
                    { 57, "How would you rate hospitals' hygiene?", 0, 12 },
                    { 55, "Your general grade for medical stuffs' service", 0, 11 },
                    { 40, "Your general grade for medical stuffs' service", 0, 8 },
                    { 41, "How would you rate our appointment organisation?", 0, 9 },
                    { 42, "How would you rate hospitals' hygiene?", 0, 9 },
                    { 43, "How good were procedure for booking appointment?", 0, 9 },
                    { 44, "How easy was to use our application?", 0, 9 },
                    { 45, "Your general grade for whole hospital' service", 0, 9 },
                    { 46, "How careful did doctor listen you?", 0, 10 },
                    { 47, "Has doctor been polite?", 0, 10 },
                    { 48, "Has he explained you your condition enough that you can understand it?", 0, 10 },
                    { 49, "How would you rate doctors' professionalism?", 0, 10 },
                    { 50, "Your general grade for doctors' service", 0, 10 },
                    { 51, "How much our medical staff were polite?", 0, 11 },
                    { 52, "How would you rate time span that you spend waiting untill doctor attended you?", 0, 11 },
                    { 53, "How prepared were stuff for emergency situations?", 0, 11 },
                    { 54, "How good has stuff explained you our procedures?", 0, 11 },
                    { 56, "How would you rate our appointment organisation?", 0, 12 },
                    { 150, "Your general grade for whole hospital' service", 3, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Day_DoctorId",
                table: "Day",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyCategories_SurveyId",
                table: "SurveyCategories",
                column: "SurveyId");

            migrationBuilder.CreateIndex(
                name: "IX_SurveyQuestions_SurveyCategoryId",
                table: "SurveyQuestions",
                column: "SurveyCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Surveys_AppointmentId",
                table: "Surveys",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDay_DoctorId",
                table: "WorkDay",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergenForPatients");

            migrationBuilder.DropTable(
                name: "Allergens");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "CanceledAppointments");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "FeedbackMessages");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Renovations");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "SurveyQuestions");

            migrationBuilder.DropTable(
                name: "Transfer");

            migrationBuilder.DropTable(
                name: "WorkDay");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "SurveyCategories");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Surveys");

            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
