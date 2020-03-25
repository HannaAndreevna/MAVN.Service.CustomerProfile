﻿// <auto-generated />
using System;
using Lykke.Service.CustomerProfile.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.CustomerProfile.MsSqlRepositories.Migrations
{
    [DbContext(typeof(CustomerProfileContext))]
    [Migration("20190703145122_AddCountry")]
    partial class AddCountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("customer_profile")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileArchiveEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<string>("Country")
                        .HasColumnName("country");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("Registered")
                        .HasColumnName("registered_at");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("customer_profile_archive");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<string>("Country")
                        .HasColumnName("country");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("Registered")
                        .HasColumnName("registered_at");

                    b.HasKey("CustomerId");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("Email");

                    b.ToTable("customer_profile");
                });
#pragma warning restore 612, 618
        }
    }
}
