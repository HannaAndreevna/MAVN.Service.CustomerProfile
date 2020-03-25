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
    [Migration("20191203151651_AddFullNameToFriendReferral")]
    partial class AddFullNameToFriendReferral
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("customer_profile")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.AdminProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_id");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnName("company");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnName("department");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnName("job_title");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number");

                    b.HasKey("AdminId");

                    b.ToTable("admin_profiles_archive");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.AdminProfileEntity", b =>
                {
                    b.Property<Guid>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_id");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnName("company");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnName("department");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnName("job_title");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number");

                    b.HasKey("AdminId");

                    b.HasIndex("Email");

                    b.ToTable("admin_profiles");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileArchiveEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<int>("CountryOfNationalityId")
                        .HasColumnName("country_of_nationality_id");

                    b.Property<int?>("CountryOfResidenceId")
                        .HasColumnName("country_of_residence_id");

                    b.Property<int?>("CountryPhoneCodeId")
                        .HasColumnName("country_phone_code_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified");

                    b.Property<bool>("IsPhoneVerified")
                        .HasColumnName("phone_verified");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("Registered")
                        .HasColumnName("registered_at");

                    b.Property<string>("ShortPhoneNumber")
                        .HasColumnName("short_phone_number");

                    b.Property<string>("TierId")
                        .HasColumnName("tier_id");

                    b.Property<bool>("WasPhoneEverVerified")
                        .HasColumnName("was_phone_ever_verified");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email");

                    b.ToTable("customer_profile_archive");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileEntity", b =>
                {
                    b.Property<string>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("customer_id");

                    b.Property<int>("CountryOfNationalityId")
                        .HasColumnName("country_of_nationality_id");

                    b.Property<int?>("CountryOfResidenceId")
                        .HasColumnName("country_of_residence_id");

                    b.Property<int?>("CountryPhoneCodeId")
                        .HasColumnName("country_phone_code_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnName("email_verified");

                    b.Property<bool>("IsPhoneVerified")
                        .HasColumnName("phone_verified");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name");

                    b.Property<string>("LowerCasedEmail")
                        .IsRequired()
                        .HasColumnName("lower_cased_email");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("Registered")
                        .HasColumnName("registered_at");

                    b.Property<string>("ShortPhoneNumber")
                        .HasColumnName("short_phone_number");

                    b.Property<string>("TierId")
                        .HasColumnName("tier_id");

                    b.Property<bool>("WasEmailEverVerified")
                        .HasColumnName("was_email_ever_verified");

                    b.Property<bool>("WasPhoneEverVerified")
                        .HasColumnName("was_phone_ever_verified");

                    b.HasKey("CustomerId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LowerCasedEmail")
                        .IsUnique();

                    b.ToTable("customer_profile");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.LoginProviderEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnName("customer_id");

                    b.Property<int>("LoginProvider")
                        .HasColumnName("login_provider");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("login_providers");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.PartnerContactArchiveEntity", b =>
                {
                    b.Property<string>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("location_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.HasKey("LocationId");

                    b.ToTable("partner_contact_archive");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.PartnerContactEntity", b =>
                {
                    b.Property<string>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("location_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .HasColumnName("phone_number");

                    b.HasKey("LocationId");

                    b.HasIndex("Email");

                    b.HasIndex("PhoneNumber");

                    b.ToTable("partner_contact");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralFriendProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("ReferralFriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_friend_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("full_name");

                    b.Property<Guid>("ReferrerId")
                        .HasColumnName("referrer_id");

                    b.HasKey("ReferralFriendId");

                    b.ToTable("referral_friend_profiles_archive");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralFriendProfileEntity", b =>
                {
                    b.Property<Guid>("ReferralFriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_friend_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnName("full_name");

                    b.Property<Guid>("ReferrerId")
                        .HasColumnName("referrer_id");

                    b.HasKey("ReferralFriendId");

                    b.HasIndex("Email");

                    b.HasIndex("ReferralFriendId");

                    b.ToTable("referral_friend_profiles");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralHotelProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("ReferralHotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_hotel_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.HasKey("ReferralHotelId");

                    b.ToTable("referral_hotel_profiles_archive");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralHotelProfileEntity", b =>
                {
                    b.Property<Guid>("ReferralHotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_hotel_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number");

                    b.HasKey("ReferralHotelId");

                    b.HasIndex("Email");

                    b.ToTable("referral_hotel_profiles");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralLeadProfileArchiveEntity", b =>
                {
                    b.Property<Guid>("ReferralLeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_lead_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name");

                    b.Property<string>("Note")
                        .HasColumnName("note");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number");

                    b.HasKey("ReferralLeadId");

                    b.ToTable("referral_lead_profiles_archive");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.ReferralLeadProfileEntity", b =>
                {
                    b.Property<Guid>("ReferralLeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("referral_lead_id");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("last_name");

                    b.Property<string>("Note")
                        .HasColumnName("note");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("phone_number");

                    b.HasKey("ReferralLeadId");

                    b.HasIndex("Email");

                    b.HasIndex("PhoneNumber");

                    b.ToTable("referral_lead_profiles");
                });

            modelBuilder.Entity("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.LoginProviderEntity", b =>
                {
                    b.HasOne("Lykke.Service.CustomerProfile.MsSqlRepositories.Entities.CustomerProfileEntity", "CustomerProfile")
                        .WithMany("LoginProviders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
