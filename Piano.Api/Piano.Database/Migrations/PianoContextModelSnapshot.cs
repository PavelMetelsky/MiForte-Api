﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Piano.Database;

#nullable disable

namespace Piano.Database.Migrations
{
    [DbContext(typeof(PianoContext))]
    partial class PianoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Piano.Entities.SocialLink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Link");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SocialLinks", (string)null);
                });

            modelBuilder.Entity("Piano.Entities.Subscriptions.Session", b =>
                {
                    b.Property<Guid>("SessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("SessionId");

                    b.Property<DateTime>("ClassDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ClassDate");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval")
                        .HasColumnName("Duration");

                    b.Property<Guid>("MentorId")
                        .HasColumnType("uuid");

                    b.Property<int>("State")
                        .HasColumnType("integer")
                        .HasColumnName("State");

                    b.Property<Guid?>("SubscriptionCardId")
                        .HasColumnType("uuid");

                    b.HasKey("SessionId");

                    b.HasIndex("SubscriptionCardId");

                    b.ToTable("Sessions", (string)null);
                });

            modelBuilder.Entity("Piano.Entities.Subscriptions.SubscriptionCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("Id");

                    b.Property<DateTime>("ActiveMonth")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("ActiveMonth");

                    b.Property<DateTime>("BuyingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("BuyingDate");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Subscriptions", (string)null);
                });

            modelBuilder.Entity("Piano.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("UserId");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Country");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Password");

                    b.Property<int>("Role")
                        .HasColumnType("integer")
                        .HasColumnName("Role");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Telephone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Piano.Entities.SocialLink", b =>
                {
                    b.HasOne("Piano.Entities.User", null)
                        .WithMany("SocialLinks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Piano.Entities.Subscriptions.Session", b =>
                {
                    b.HasOne("Piano.Entities.Subscriptions.SubscriptionCard", null)
                        .WithMany("Sessions")
                        .HasForeignKey("SubscriptionCardId");
                });

            modelBuilder.Entity("Piano.Entities.Subscriptions.SubscriptionCard", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("Piano.Entities.User", b =>
                {
                    b.Navigation("SocialLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
