﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebCore.Models;

namespace WebCore.Migrations
{
    [DbContext(typeof(LogInfoContext))]
    [Migration("20171127084547_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebCore.Models.LogInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("HttpRequestMethod");

                    b.Property<int>("HttpStatusCode");

                    b.Property<string>("IpAddress");

                    b.Property<string>("Path");

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.ToTable("LogInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
