﻿// <auto-generated />
using System;
using KenshuServiceDatabaseLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KenshuServiceDatabaseLibrary.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20240418051506_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KenshuServiceDatabaseLibrary.T_Billing_Data", b =>
                {
                    b.Property<DateOnly>("billing_ym")
                        .HasColumnType("date");

                    b.Property<int>("member_id")
                        .HasColumnType("integer");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("amount")
                        .HasColumnType("integer");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("member_end_date")
                        .HasColumnType("date");

                    b.Property<DateOnly>("member_start_date")
                        .HasColumnType("date");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("payment_method")
                        .HasColumnType("integer");

                    b.Property<int>("tax_ratio")
                        .HasColumnType("integer");

                    b.Property<int>("total")
                        .HasColumnType("integer");

                    b.HasKey("billing_ym", "member_id");

                    b.ToTable("Billing_Data");
                });

            modelBuilder.Entity("KenshuServiceDatabaseLibrary.T_Billing_Detail_Data", b =>
                {
                    b.Property<DateOnly>("billing_ym")
                        .HasColumnType("date");

                    b.Property<int>("member_id")
                        .HasColumnType("integer");

                    b.Property<int>("charge_id")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("end_date")
                        .HasColumnType("date");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("start_date")
                        .HasColumnType("date");

                    b.HasKey("billing_ym", "member_id", "charge_id");

                    b.ToTable("Billing_Data_Detail");
                });

            modelBuilder.Entity("KenshuServiceDatabaseLibrary.T_Billing_Status", b =>
                {
                    b.Property<DateOnly>("billing_ym")
                        .HasColumnType("date");

                    b.Property<bool>("is_commited")
                        .HasColumnType("boolean");

                    b.HasKey("billing_ym");

                    b.ToTable("Billing_Status");
                });

            modelBuilder.Entity("KenshuServiceDatabaseLibrary.T_Charge", b =>
                {
                    b.Property<int>("charge_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("charge_id"));

                    b.Property<int?>("amount")
                        .HasColumnType("integer");

                    b.Property<string>("charge_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly?>("endDate")
                        .HasColumnType("date");

                    b.Property<DateOnly?>("startDate")
                        .HasColumnType("date");

                    b.HasKey("charge_id");

                    b.ToTable("Charges");
                });

            modelBuilder.Entity("KenshuServiceDatabaseLibrary.T_Member", b =>
                {
                    b.Property<int>("member_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("member_id"));

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<DateOnly?>("end_date")
                        .HasColumnType("date");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("payment_method")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("start_date")
                        .HasColumnType("date");

                    b.HasKey("member_id");

                    b.ToTable("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
