﻿// <auto-generated />
using DataTransfer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataTransfer.Migrations
{
    [DbContext(typeof(OlympicContext))]
    partial class OlympicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataTransfer.Models.Country", b =>
                {
                    b.Property<string>("CountryID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlagImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CountryID");

                    b.HasIndex("GameID");

                    b.HasIndex("SportID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = "CA",
                            CountryName = "Canada",
                            FlagImage = "CA.png",
                            GameID = "wint",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "SW",
                            CountryName = "Sweden",
                            FlagImage = "SW.png",
                            GameID = "wint",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "GB",
                            CountryName = "Great Britain",
                            FlagImage = "GB.png",
                            GameID = "wint",
                            SportID = "curl"
                        },
                        new
                        {
                            CountryID = "JA",
                            CountryName = "Jamaica",
                            FlagImage = "JA.png",
                            GameID = "wint",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "IL",
                            CountryName = "Italy",
                            FlagImage = "IL.png",
                            GameID = "wint",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "JP",
                            CountryName = "Japan",
                            FlagImage = "JP.png",
                            GameID = "wint",
                            SportID = "bobsleigh"
                        },
                        new
                        {
                            CountryID = "GA",
                            CountryName = "Germany",
                            FlagImage = "GA.png",
                            GameID = "summ",
                            SportID = "dive"
                        },
                        new
                        {
                            CountryID = "CN",
                            CountryName = "China",
                            FlagImage = "CN.png",
                            GameID = "summ",
                            SportID = "dive"
                        },
                        new
                        {
                            CountryID = "MX",
                            CountryName = "Mexico",
                            FlagImage = "MX.png",
                            GameID = "summ",
                            SportID = "dive"
                        },
                        new
                        {
                            CountryID = "BR",
                            CountryName = "Brazil",
                            FlagImage = "BR.png",
                            GameID = "summ",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "NL",
                            CountryName = "Netherlands",
                            FlagImage = "NL.png",
                            GameID = "summ",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "US",
                            CountryName = "United States",
                            FlagImage = "US.png",
                            GameID = "summ",
                            SportID = "cycling"
                        },
                        new
                        {
                            CountryID = "TH",
                            CountryName = "Thailand",
                            FlagImage = "TH.png",
                            GameID = "para",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "UY",
                            CountryName = "Uruguay",
                            FlagImage = "UY.png",
                            GameID = "para",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "UA",
                            CountryName = "Ukraine",
                            FlagImage = "UA.png",
                            GameID = "para",
                            SportID = "archery"
                        },
                        new
                        {
                            CountryID = "AT",
                            CountryName = "Austria",
                            FlagImage = "AT.png",
                            GameID = "para",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "PK",
                            CountryName = "Pakistan",
                            FlagImage = "PK.png",
                            GameID = "para",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "ZI",
                            CountryName = "Zimbabwe",
                            FlagImage = "ZI.png",
                            GameID = "para",
                            SportID = "canoe"
                        },
                        new
                        {
                            CountryID = "FR",
                            CountryName = "France",
                            FlagImage = "FR.png",
                            GameID = "youth",
                            SportID = "dance"
                        },
                        new
                        {
                            CountryID = "CY",
                            CountryName = "Cyprus",
                            FlagImage = "CY.png",
                            GameID = "youth",
                            SportID = "dance"
                        },
                        new
                        {
                            CountryID = "RU",
                            CountryName = "Russia",
                            FlagImage = "RU.png",
                            GameID = "youth",
                            SportID = "dance"
                        },
                        new
                        {
                            CountryID = "FI",
                            CountryName = "Finland",
                            FlagImage = "FI.png",
                            GameID = "youth",
                            SportID = "skateboard"
                        },
                        new
                        {
                            CountryID = "SK",
                            CountryName = "Slovakia",
                            FlagImage = "SK.png",
                            GameID = "youth",
                            SportID = "skateboard"
                        },
                        new
                        {
                            CountryID = "PT",
                            CountryName = "Portugal",
                            FlagImage = "PT.png",
                            GameID = "youth",
                            SportID = "skateboard"
                        });
                });

            modelBuilder.Entity("DataTransfer.Models.Game", b =>
                {
                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("GameName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameID");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameID = "wint",
                            GameName = "Winter Olympics"
                        },
                        new
                        {
                            GameID = "summ",
                            GameName = "Summer Olympics"
                        },
                        new
                        {
                            GameID = "para",
                            GameName = "Paralympics"
                        },
                        new
                        {
                            GameID = "youth",
                            GameName = "Youth Olympic Games"
                        });
                });

            modelBuilder.Entity("DataTransfer.Models.Sport", b =>
                {
                    b.Property<string>("SportID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SportName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SportID");

                    b.ToTable("Sports");

                    b.HasData(
                        new
                        {
                            SportID = "curl",
                            SportName = "Curling/Indoor"
                        },
                        new
                        {
                            SportID = "bobsleigh",
                            SportName = "Bobsleigh/Outdoor"
                        },
                        new
                        {
                            SportID = "dive",
                            SportName = "Diving/Indoor"
                        },
                        new
                        {
                            SportID = "cycling",
                            SportName = "Road Cycling/Outdoor"
                        },
                        new
                        {
                            SportID = "archery",
                            SportName = "Archery/Indoor"
                        },
                        new
                        {
                            SportID = "canoe",
                            SportName = "Canoe Sprint/Outdoor"
                        },
                        new
                        {
                            SportID = "dance",
                            SportName = "Breakdancing/Indoor"
                        },
                        new
                        {
                            SportID = "skateboard",
                            SportName = "Skateboarding/Outdoor"
                        });
                });

            modelBuilder.Entity("DataTransfer.Models.Country", b =>
                {
                    b.HasOne("DataTransfer.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameID");

                    b.HasOne("DataTransfer.Models.Sport", "Sport")
                        .WithMany()
                        .HasForeignKey("SportID");

                    b.Navigation("Game");

                    b.Navigation("Sport");
                });
#pragma warning restore 612, 618
        }
    }
}
