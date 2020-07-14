﻿// <auto-generated />
using BlazorChat.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorChat_v3.Api.Migrations
{
    [DbContext(typeof(AppDbContextClass))]
    partial class AppDbContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("BlazorChat_v4.Shared.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 3,
                            FirstName = "Jack",
                            LastName = "Rassel"
                        },
                        new
                        {
                            ContactId = 1,
                            FirstName = "Anatoliy",
                            LastName = "Rassel"
                        },
                        new
                        {
                            ContactId = 2,
                            FirstName = "Lara",
                            LastName = "Rassel"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}