﻿// <auto-generated />
using System;
using Donations.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Donations.DAL.Migrations
{
    [DbContext(typeof(DonationsContext))]
    [Migration("20231029110713_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Donations.Data.Models.Donation", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("TEXT");

                    b.Property<int>("Sum")
                        .HasMaxLength(100)
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserID")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("UserID");

                    b.ToTable("Donations");

                    b.HasData(
                        new
                        {
                            ID = new Guid("019f0ed1-0dc5-4def-9f70-6092d8a33c69"),
                            Date = new DateTime(2023, 3, 11, 10, 33, 27, 131, DateTimeKind.Local).AddTicks(7976),
                            ProductID = new Guid("fb35566f-ebc9-4661-85fa-26237b229e9c"),
                            Sum = 25,
                            UserID = new Guid("bbc5a032-a4b1-43ca-b663-fb02b6f9242c")
                        },
                        new
                        {
                            ID = new Guid("c7373ca3-4901-404b-9662-d218ff1335da"),
                            Date = new DateTime(2022, 12, 3, 5, 53, 3, 902, DateTimeKind.Local).AddTicks(9375),
                            ProductID = new Guid("4ac61226-398b-4f8d-b348-c64bad6843ff"),
                            Sum = 392,
                            UserID = new Guid("ffd1fb5d-0ec0-40a5-a461-a00564b604d0")
                        },
                        new
                        {
                            ID = new Guid("147c88e8-ec6d-4399-acb4-4bf6a4bed15a"),
                            Date = new DateTime(2023, 7, 10, 13, 56, 50, 364, DateTimeKind.Local).AddTicks(6165),
                            ProductID = new Guid("064ce5fc-bc7d-4984-bd5e-dea025342beb"),
                            Sum = 979,
                            UserID = new Guid("39497e1f-14a9-41ed-b72f-aeb54198f7d1")
                        },
                        new
                        {
                            ID = new Guid("ccbc87cf-99b0-4449-ba92-5ba668dacedd"),
                            Date = new DateTime(2023, 5, 15, 7, 59, 2, 283, DateTimeKind.Local).AddTicks(6983),
                            ProductID = new Guid("5ed2a03c-deb9-4836-9f36-2c76e5521911"),
                            Sum = 133,
                            UserID = new Guid("ee5b9233-b6c9-4358-9d99-2aa0f6b6ce83")
                        },
                        new
                        {
                            ID = new Guid("f8d9132b-5c72-4a20-99f2-f8ba3214d4bb"),
                            Date = new DateTime(2023, 3, 12, 12, 37, 20, 482, DateTimeKind.Local).AddTicks(3859),
                            ProductID = new Guid("eef30bd5-1f3a-4714-a3f3-9b705f0751b4"),
                            Sum = 529,
                            UserID = new Guid("89f3f533-1524-4b09-9b7e-06fa18db8400")
                        },
                        new
                        {
                            ID = new Guid("26cd8818-307a-460a-ad3b-c6d8a2f91bf0"),
                            Date = new DateTime(2023, 3, 1, 9, 50, 6, 480, DateTimeKind.Local).AddTicks(448),
                            ProductID = new Guid("456ecc44-74c3-4040-a56b-b48afaa92cf1"),
                            Sum = 429,
                            UserID = new Guid("76e92b88-dd5c-4f15-bbf2-1bc24394679e")
                        },
                        new
                        {
                            ID = new Guid("c700cc19-dbbd-4324-ae0f-13c607a01995"),
                            Date = new DateTime(2023, 9, 13, 0, 24, 59, 456, DateTimeKind.Local).AddTicks(5275),
                            ProductID = new Guid("456ecc44-74c3-4040-a56b-b48afaa92cf1"),
                            Sum = 588,
                            UserID = new Guid("a98e8aad-8179-4b19-9de7-80f6cf4374bf")
                        },
                        new
                        {
                            ID = new Guid("0768ad68-992d-4d6f-b31e-99753708057a"),
                            Date = new DateTime(2023, 4, 27, 18, 49, 20, 51, DateTimeKind.Local).AddTicks(1742),
                            ProductID = new Guid("d653c4c4-05aa-4d0b-afb9-1d9691d2b193"),
                            Sum = 116,
                            UserID = new Guid("291dbbf0-e6b5-4ed1-b49e-d2b2fb0f7f51")
                        },
                        new
                        {
                            ID = new Guid("e01e2e85-e3ab-4587-b448-a2fa13bc9179"),
                            Date = new DateTime(2023, 9, 16, 16, 37, 12, 110, DateTimeKind.Local).AddTicks(3955),
                            ProductID = new Guid("3891489a-2810-4bc3-92d7-adbfc6717d62"),
                            Sum = 112,
                            UserID = new Guid("8eaa9d95-4493-4aba-bacf-c9e0e19a4a87")
                        },
                        new
                        {
                            ID = new Guid("e3ce9a5c-ea94-43ca-b352-e7c442e81ce2"),
                            Date = new DateTime(2023, 3, 15, 0, 42, 32, 448, DateTimeKind.Local).AddTicks(3256),
                            ProductID = new Guid("ffa899c7-9e3a-42c2-af4b-eb3fbdc08502"),
                            Sum = 989,
                            UserID = new Guid("8eaa9d95-4493-4aba-bacf-c9e0e19a4a87")
                        },
                        new
                        {
                            ID = new Guid("092887a1-8524-4cfd-8743-85256e656e35"),
                            Date = new DateTime(2023, 4, 17, 23, 11, 11, 347, DateTimeKind.Local).AddTicks(2351),
                            ProductID = new Guid("4d86fbd4-03bd-4f77-b231-67be223c0e80"),
                            Sum = 750,
                            UserID = new Guid("aca04c7d-ca9b-47ba-a6f0-8158c02dacd7")
                        },
                        new
                        {
                            ID = new Guid("b41c274a-8682-4e89-8fb6-2898cbbfee53"),
                            Date = new DateTime(2023, 7, 29, 19, 44, 5, 151, DateTimeKind.Local).AddTicks(1861),
                            ProductID = new Guid("fb35566f-ebc9-4661-85fa-26237b229e9c"),
                            Sum = 799,
                            UserID = new Guid("291dbbf0-e6b5-4ed1-b49e-d2b2fb0f7f51")
                        },
                        new
                        {
                            ID = new Guid("33fe352e-3f0a-4e4c-850c-78a10ccb6ccf"),
                            Date = new DateTime(2023, 7, 25, 0, 20, 16, 48, DateTimeKind.Local).AddTicks(3699),
                            ProductID = new Guid("ffa899c7-9e3a-42c2-af4b-eb3fbdc08502"),
                            Sum = 821,
                            UserID = new Guid("8d8f9b1b-3f16-43a9-8458-57c30c3a145b")
                        },
                        new
                        {
                            ID = new Guid("b9c3f7bc-2ef6-405c-b231-008b5f277a51"),
                            Date = new DateTime(2023, 7, 10, 1, 59, 10, 659, DateTimeKind.Local).AddTicks(9500),
                            ProductID = new Guid("bf4b218d-54e3-4e52-9eda-32d3ec59eb09"),
                            Sum = 14,
                            UserID = new Guid("5acd4afe-9ffe-42d3-a702-80092c5c086e")
                        },
                        new
                        {
                            ID = new Guid("b48bb0ec-c6af-4b42-aeb3-a449a6785da5"),
                            Date = new DateTime(2022, 11, 3, 0, 6, 18, 363, DateTimeKind.Local).AddTicks(6602),
                            ProductID = new Guid("5ed2a03c-deb9-4836-9f36-2c76e5521911"),
                            Sum = 818,
                            UserID = new Guid("0e324b59-0cbf-419d-b1d1-ce0cd09af5da")
                        },
                        new
                        {
                            ID = new Guid("79a0a7fc-25a0-4135-875d-2d264d84c36b"),
                            Date = new DateTime(2023, 1, 22, 18, 19, 57, 908, DateTimeKind.Local).AddTicks(1602),
                            ProductID = new Guid("eaa5b12f-71f5-4fd1-bbe8-af1625b99ea0"),
                            Sum = 5,
                            UserID = new Guid("dcd96941-0a8c-4fa3-b604-ce8ea769b42a")
                        },
                        new
                        {
                            ID = new Guid("44b90de3-3dfe-4665-95ec-8fa5ceca616f"),
                            Date = new DateTime(2023, 3, 7, 0, 58, 32, 618, DateTimeKind.Local).AddTicks(4137),
                            ProductID = new Guid("a882a4a0-7073-448d-96a5-7e9f28796f0c"),
                            Sum = 54,
                            UserID = new Guid("3c1e1e68-3e5f-4b1f-b93f-2f9776782406")
                        },
                        new
                        {
                            ID = new Guid("c83c46c9-1461-458c-879b-13613b7d4dae"),
                            Date = new DateTime(2023, 6, 27, 9, 31, 44, 910, DateTimeKind.Local).AddTicks(2356),
                            ProductID = new Guid("fb35566f-ebc9-4661-85fa-26237b229e9c"),
                            Sum = 546,
                            UserID = new Guid("5596dfe4-a185-4678-9925-343e89563fe7")
                        },
                        new
                        {
                            ID = new Guid("fe94c47f-66ff-4618-bd7f-50ae269ea783"),
                            Date = new DateTime(2023, 2, 14, 11, 5, 12, 106, DateTimeKind.Local).AddTicks(9317),
                            ProductID = new Guid("064ce5fc-bc7d-4984-bd5e-dea025342beb"),
                            Sum = 723,
                            UserID = new Guid("ae27ac25-40b3-4a58-b108-05f67bd839a1")
                        },
                        new
                        {
                            ID = new Guid("9a9bc538-5a47-41ae-ae82-40726ed2ddc1"),
                            Date = new DateTime(2023, 2, 7, 19, 49, 48, 741, DateTimeKind.Local).AddTicks(9851),
                            ProductID = new Guid("fef096ee-14a7-4cad-b6c5-eeeea4035906"),
                            Sum = 255,
                            UserID = new Guid("8eaa9d95-4493-4aba-bacf-c9e0e19a4a87")
                        },
                        new
                        {
                            ID = new Guid("83d32ce3-b3c9-4ea7-b9fb-ae6a4ecbafc7"),
                            Date = new DateTime(2023, 3, 17, 6, 42, 56, 920, DateTimeKind.Local).AddTicks(906),
                            ProductID = new Guid("fcd8c775-5ec9-40ce-a06c-1066cf463588"),
                            Sum = 629,
                            UserID = new Guid("5acd4afe-9ffe-42d3-a702-80092c5c086e")
                        },
                        new
                        {
                            ID = new Guid("f4b1a23b-6e37-4a98-957a-bd6e93a72bcd"),
                            Date = new DateTime(2023, 1, 9, 7, 38, 22, 67, DateTimeKind.Local).AddTicks(121),
                            ProductID = new Guid("72bf44f1-5274-4a0b-ad89-2aef04e95c5f"),
                            Sum = 876,
                            UserID = new Guid("b60dc4a1-5f30-4b33-a2f1-b7e30298547d")
                        },
                        new
                        {
                            ID = new Guid("2315bf46-111b-4bcc-8e54-42b727fc600f"),
                            Date = new DateTime(2023, 8, 26, 21, 13, 7, 122, DateTimeKind.Local).AddTicks(2101),
                            ProductID = new Guid("eaa5b12f-71f5-4fd1-bbe8-af1625b99ea0"),
                            Sum = 240,
                            UserID = new Guid("06a6656c-3ab2-425d-b97c-a0dcd34eb4cf")
                        },
                        new
                        {
                            ID = new Guid("5aa6d85f-eae1-476b-a4e3-ede86fc7c7c7"),
                            Date = new DateTime(2023, 3, 26, 6, 52, 28, 64, DateTimeKind.Local).AddTicks(2425),
                            ProductID = new Guid("72bf44f1-5274-4a0b-ad89-2aef04e95c5f"),
                            Sum = 438,
                            UserID = new Guid("8d8f9b1b-3f16-43a9-8458-57c30c3a145b")
                        },
                        new
                        {
                            ID = new Guid("b4434821-4a1d-4fea-bc67-cf0fb085f672"),
                            Date = new DateTime(2023, 5, 10, 5, 9, 17, 346, DateTimeKind.Local).AddTicks(3486),
                            ProductID = new Guid("eef30bd5-1f3a-4714-a3f3-9b705f0751b4"),
                            Sum = 881,
                            UserID = new Guid("f12da569-4356-4292-8a55-6418f8164578")
                        },
                        new
                        {
                            ID = new Guid("4c6a0418-4702-4eb4-81fc-cc8090307b24"),
                            Date = new DateTime(2023, 1, 29, 12, 57, 13, 138, DateTimeKind.Local).AddTicks(235),
                            ProductID = new Guid("daf510a3-2f7f-4d89-9018-7510791f76b6"),
                            Sum = 212,
                            UserID = new Guid("8eaa9d95-4493-4aba-bacf-c9e0e19a4a87")
                        },
                        new
                        {
                            ID = new Guid("4598c136-f3d4-4fe3-b537-3ac38d35296a"),
                            Date = new DateTime(2023, 2, 22, 23, 29, 58, 585, DateTimeKind.Local).AddTicks(9295),
                            ProductID = new Guid("4ac61226-398b-4f8d-b348-c64bad6843ff"),
                            Sum = 751,
                            UserID = new Guid("5596dfe4-a185-4678-9925-343e89563fe7")
                        },
                        new
                        {
                            ID = new Guid("690c7841-1b13-441d-beb5-d134a4290fe5"),
                            Date = new DateTime(2023, 7, 19, 15, 3, 21, 705, DateTimeKind.Local).AddTicks(635),
                            ProductID = new Guid("4d86fbd4-03bd-4f77-b231-67be223c0e80"),
                            Sum = 719,
                            UserID = new Guid("a98e8aad-8179-4b19-9de7-80f6cf4374bf")
                        },
                        new
                        {
                            ID = new Guid("58de7130-2832-434b-a965-fae1a02db679"),
                            Date = new DateTime(2023, 6, 15, 12, 3, 26, 47, DateTimeKind.Local).AddTicks(3530),
                            ProductID = new Guid("fef096ee-14a7-4cad-b6c5-eeeea4035906"),
                            Sum = 200,
                            UserID = new Guid("28cfcb35-f06f-477d-8852-f50b1691ec26")
                        },
                        new
                        {
                            ID = new Guid("a73194cd-b153-4aaf-b51d-1965ea78af21"),
                            Date = new DateTime(2023, 8, 22, 15, 5, 41, 826, DateTimeKind.Local).AddTicks(4118),
                            ProductID = new Guid("50070285-4c74-45cb-af08-89771e05b5ff"),
                            Sum = 231,
                            UserID = new Guid("aca04c7d-ca9b-47ba-a6f0-8158c02dacd7")
                        });
                });

            modelBuilder.Entity("Donations.Data.Models.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = new Guid("b0fd8322-10c6-4614-b381-36bd21693dba"),
                            Name = "dolorem"
                        },
                        new
                        {
                            ID = new Guid("a882a4a0-7073-448d-96a5-7e9f28796f0c"),
                            Name = "ipsum"
                        },
                        new
                        {
                            ID = new Guid("5ed2a03c-deb9-4836-9f36-2c76e5521911"),
                            Name = "est"
                        },
                        new
                        {
                            ID = new Guid("71a22a94-5ee6-4552-90ae-f58b4c05799b"),
                            Name = "iste"
                        },
                        new
                        {
                            ID = new Guid("456ecc44-74c3-4040-a56b-b48afaa92cf1"),
                            Name = "nesciunt"
                        },
                        new
                        {
                            ID = new Guid("67741be7-ef40-4ac6-af3e-9f719224d02a"),
                            Name = "quia"
                        },
                        new
                        {
                            ID = new Guid("eef30bd5-1f3a-4714-a3f3-9b705f0751b4"),
                            Name = "tempora"
                        },
                        new
                        {
                            ID = new Guid("72bf44f1-5274-4a0b-ad89-2aef04e95c5f"),
                            Name = "eveniet"
                        },
                        new
                        {
                            ID = new Guid("fef096ee-14a7-4cad-b6c5-eeeea4035906"),
                            Name = "quae"
                        },
                        new
                        {
                            ID = new Guid("daf510a3-2f7f-4d89-9018-7510791f76b6"),
                            Name = "enim"
                        },
                        new
                        {
                            ID = new Guid("7778a6ac-f4e0-4484-9e92-b7686c120d2b"),
                            Name = "asperiores"
                        },
                        new
                        {
                            ID = new Guid("fcd8c775-5ec9-40ce-a06c-1066cf463588"),
                            Name = "voluptatum"
                        },
                        new
                        {
                            ID = new Guid("8c20fe20-8c2c-40c4-83aa-b19505d5f4e7"),
                            Name = "et"
                        },
                        new
                        {
                            ID = new Guid("eaa5b12f-71f5-4fd1-bbe8-af1625b99ea0"),
                            Name = "dolores"
                        },
                        new
                        {
                            ID = new Guid("bff7f4e3-e27f-4f88-9cd6-191899094b67"),
                            Name = "perferendis"
                        },
                        new
                        {
                            ID = new Guid("fb35566f-ebc9-4661-85fa-26237b229e9c"),
                            Name = "quia"
                        },
                        new
                        {
                            ID = new Guid("d653c4c4-05aa-4d0b-afb9-1d9691d2b193"),
                            Name = "est"
                        },
                        new
                        {
                            ID = new Guid("6e48ec08-7f96-4572-896f-13e9b3e263d6"),
                            Name = "est"
                        },
                        new
                        {
                            ID = new Guid("4d86fbd4-03bd-4f77-b231-67be223c0e80"),
                            Name = "quam"
                        },
                        new
                        {
                            ID = new Guid("bf4b218d-54e3-4e52-9eda-32d3ec59eb09"),
                            Name = "ab"
                        },
                        new
                        {
                            ID = new Guid("3891489a-2810-4bc3-92d7-adbfc6717d62"),
                            Name = "porro"
                        },
                        new
                        {
                            ID = new Guid("50070285-4c74-45cb-af08-89771e05b5ff"),
                            Name = "enim"
                        },
                        new
                        {
                            ID = new Guid("393f3d80-01a0-4692-80c0-06d01146f208"),
                            Name = "mollitia"
                        },
                        new
                        {
                            ID = new Guid("064ce5fc-bc7d-4984-bd5e-dea025342beb"),
                            Name = "commodi"
                        },
                        new
                        {
                            ID = new Guid("aae59dc0-4cb2-4d77-843e-f707736627fd"),
                            Name = "aut"
                        },
                        new
                        {
                            ID = new Guid("4ac61226-398b-4f8d-b348-c64bad6843ff"),
                            Name = "quia"
                        },
                        new
                        {
                            ID = new Guid("e7773c9e-6c69-4df2-b12b-9546e6fafae0"),
                            Name = "voluptas"
                        },
                        new
                        {
                            ID = new Guid("65faf6e7-c2c8-49a7-977c-b137290d0264"),
                            Name = "aut"
                        },
                        new
                        {
                            ID = new Guid("ffa899c7-9e3a-42c2-af4b-eb3fbdc08502"),
                            Name = "laudantium"
                        },
                        new
                        {
                            ID = new Guid("a227715c-3e34-4fbb-8353-141f1c5c512c"),
                            Name = "eligendi"
                        });
                });

            modelBuilder.Entity("Donations.Data.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("CreditCardNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = new Guid("39497e1f-14a9-41ed-b72f-aeb54198f7d1"),
                            CreditCardNumber = "4322442881599",
                            Username = "Mindy_Carter1"
                        },
                        new
                        {
                            ID = new Guid("8eaa9d95-4493-4aba-bacf-c9e0e19a4a87"),
                            CreditCardNumber = "6759-9233-4491-2059-04",
                            Username = "Mario_Satterfield89"
                        },
                        new
                        {
                            ID = new Guid("a98e8aad-8179-4b19-9de7-80f6cf4374bf"),
                            CreditCardNumber = "3529-8923-9837-7982",
                            Username = "Kristy.Vandervort"
                        },
                        new
                        {
                            ID = new Guid("ee5b9233-b6c9-4358-9d99-2aa0f6b6ce83"),
                            CreditCardNumber = "6759-7456-8817-4234",
                            Username = "Melissa_Hansen45"
                        },
                        new
                        {
                            ID = new Guid("5596dfe4-a185-4678-9925-343e89563fe7"),
                            CreditCardNumber = "6706548554812262005",
                            Username = "Bert8"
                        },
                        new
                        {
                            ID = new Guid("76c82e71-983a-407f-9087-024f836d7473"),
                            CreditCardNumber = "6304-9339-4008-0767",
                            Username = "Wendy_Corwin13"
                        },
                        new
                        {
                            ID = new Guid("a274a555-ae23-474a-9458-e16893095317"),
                            CreditCardNumber = "6580-4340-2381-3104",
                            Username = "Arthur73"
                        },
                        new
                        {
                            ID = new Guid("aca04c7d-ca9b-47ba-a6f0-8158c02dacd7"),
                            CreditCardNumber = "5404-4999-6973-9643",
                            Username = "Marty86"
                        },
                        new
                        {
                            ID = new Guid("8571c782-dd45-4bc6-ba2e-c56d30062ce9"),
                            CreditCardNumber = "6771-8985-1364-7223",
                            Username = "Stacy_Robel96"
                        },
                        new
                        {
                            ID = new Guid("ffbe3e93-8b61-4ef5-9fe6-ad4a4a947842"),
                            CreditCardNumber = "3418-134368-69220",
                            Username = "April_Greenfelder"
                        },
                        new
                        {
                            ID = new Guid("5acd4afe-9ffe-42d3-a702-80092c5c086e"),
                            CreditCardNumber = "3529-6248-4032-7350",
                            Username = "Nicole.Flatley"
                        },
                        new
                        {
                            ID = new Guid("8d8f9b1b-3f16-43a9-8458-57c30c3a145b"),
                            CreditCardNumber = "6771291743470220",
                            Username = "Charlie.Murazik"
                        },
                        new
                        {
                            ID = new Guid("28cfcb35-f06f-477d-8852-f50b1691ec26"),
                            CreditCardNumber = "6386-6241-4979-1830",
                            Username = "Kristina_Ward"
                        },
                        new
                        {
                            ID = new Guid("bbc5a032-a4b1-43ca-b663-fb02b6f9242c"),
                            CreditCardNumber = "6394-3871-4647-6116",
                            Username = "Forrest.Ullrich67"
                        },
                        new
                        {
                            ID = new Guid("cd4281e7-33ab-43f3-ba37-53861a8655db"),
                            CreditCardNumber = "6497-6204-6371-4534-9665",
                            Username = "Irvin_Hackett57"
                        },
                        new
                        {
                            ID = new Guid("ae27ac25-40b3-4a58-b108-05f67bd839a1"),
                            CreditCardNumber = "5018483264562106422",
                            Username = "Teri_Hintz75"
                        },
                        new
                        {
                            ID = new Guid("291dbbf0-e6b5-4ed1-b49e-d2b2fb0f7f51"),
                            CreditCardNumber = "3528-6647-5518-3969",
                            Username = "Christopher_Fisher"
                        },
                        new
                        {
                            ID = new Guid("89f3f533-1524-4b09-9b7e-06fa18db8400"),
                            CreditCardNumber = "5460-5810-0834-8238",
                            Username = "Alan_Champlin32"
                        },
                        new
                        {
                            ID = new Guid("dcd96941-0a8c-4fa3-b604-ce8ea769b42a"),
                            CreditCardNumber = "3528-8366-2795-2868",
                            Username = "Cecilia76"
                        },
                        new
                        {
                            ID = new Guid("f12da569-4356-4292-8a55-6418f8164578"),
                            CreditCardNumber = "3529-3316-7863-9241",
                            Username = "Rodney44"
                        },
                        new
                        {
                            ID = new Guid("9adb2c3a-4141-4a7f-8153-2d7405ecdc5b"),
                            CreditCardNumber = "5893392861754475675",
                            Username = "Jose.Kuhlman24"
                        },
                        new
                        {
                            ID = new Guid("0e324b59-0cbf-419d-b1d1-ce0cd09af5da"),
                            CreditCardNumber = "5018-9675-4416-0285",
                            Username = "Kyle_Nienow96"
                        },
                        new
                        {
                            ID = new Guid("06a6656c-3ab2-425d-b97c-a0dcd34eb4cf"),
                            CreditCardNumber = "3695-565573-9400",
                            Username = "Blake_Harvey"
                        },
                        new
                        {
                            ID = new Guid("f545233a-64c3-422b-9de8-47a28b3bb9c7"),
                            CreditCardNumber = "6377-9786-8710-0163",
                            Username = "Tracy48"
                        },
                        new
                        {
                            ID = new Guid("8fc3e7b2-f48b-4d94-a5d4-d18b38063a43"),
                            CreditCardNumber = "5018-5202-6055-1979",
                            Username = "Tamara60"
                        },
                        new
                        {
                            ID = new Guid("76e92b88-dd5c-4f15-bbf2-1bc24394679e"),
                            CreditCardNumber = "6380-3870-5969-5617",
                            Username = "Dan.Kohler67"
                        },
                        new
                        {
                            ID = new Guid("b95ce365-c504-4597-95fa-f9da59260605"),
                            CreditCardNumber = "6580-6269-2465-8755-7650",
                            Username = "Judy.Wolff"
                        },
                        new
                        {
                            ID = new Guid("b60dc4a1-5f30-4b33-a2f1-b7e30298547d"),
                            CreditCardNumber = "6771-8979-9641-2535",
                            Username = "Andres.Conn54"
                        },
                        new
                        {
                            ID = new Guid("3c1e1e68-3e5f-4b1f-b93f-2f9776782406"),
                            CreditCardNumber = "4579412329616",
                            Username = "Danielle.Wuckert31"
                        },
                        new
                        {
                            ID = new Guid("ffd1fb5d-0ec0-40a5-a461-a00564b604d0"),
                            CreditCardNumber = "6382-7259-0227-0955",
                            Username = "Darryl_Jast"
                        });
                });

            modelBuilder.Entity("Donations.Data.Models.Donation", b =>
                {
                    b.HasOne("Donations.Data.Models.Product", "Product")
                        .WithMany("Donations")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Donations.Data.Models.User", "User")
                        .WithMany("Donations")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Donations.Data.Models.Product", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("Donations.Data.Models.User", b =>
                {
                    b.Navigation("Donations");
                });
#pragma warning restore 612, 618
        }
    }
}
