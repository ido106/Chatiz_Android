﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(WebAppContext))]
    [Migration("20220531091816_UDATE-CONTACT")]
    partial class UDATECONTACT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Contact", b =>
                {
                    b.Property<int>("IdContact")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("longtext");

                    b.Property<string>("LastMessage")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastSeen")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Server")
                        .HasColumnType("longtext");

                    b.Property<string>("TalkingTo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IdContact");

                    b.HasIndex("Username");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Domain.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ContactIdContact")
                        .HasColumnType("int");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsMine")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("TimeSent")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ContactIdContact");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ImgSrc")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("LastSeen")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Server")
                        .HasColumnType("longtext");

                    b.HasKey("Username");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.Contact", b =>
                {
                    b.HasOne("Domain.User", null)
                        .WithMany("Contacts")
                        .HasForeignKey("Username");
                });

            modelBuilder.Entity("Domain.Message", b =>
                {
                    b.HasOne("Domain.Contact", null)
                        .WithMany("Messages")
                        .HasForeignKey("ContactIdContact");
                });

            modelBuilder.Entity("Domain.Contact", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Domain.User", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
