﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaymentAPINew.Models;

namespace PaymentAPINew.Migrations
{
    [DbContext(typeof(PaymentDetailContext))]
    [Migration("20210610183324_InitialMigrate")]
    partial class InitialMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PaymentAPINew.Models.PaymentDetail", b =>
                {
                    b.Property<int>("PaymentDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CardNumber")
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("CardOwnerName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ExpirationDate")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("SecurityCode")
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("PaymentDetailId");

                    b.ToTable("paymentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
