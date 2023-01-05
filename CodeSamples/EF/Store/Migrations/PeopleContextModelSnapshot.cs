﻿// <auto-generated />
using System;
using LearnDotNet.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnDotNet.Store.Migrations
{
    [DbContext(typeof(PeopleContext))]
    partial class PeopleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.12");

            modelBuilder.Entity("LearnDotNet.Store.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("DateOfExpiration")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DateOfIssue")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PersonId1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Series")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("TypeId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("LearnDotNet.Store.Entities.DocumentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("LearnDotNet.Store.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("DateOfDeath")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset?>("DeletedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("LearnDotNet.Store.Entities.Document", b =>
                {
                    b.HasOne("LearnDotNet.Store.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LearnDotNet.Store.Entities.Person", null)
                        .WithMany("Documents")
                        .HasForeignKey("PersonId1");

                    b.HasOne("LearnDotNet.Store.Entities.DocumentType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("LearnDotNet.Store.Entities.Person", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
