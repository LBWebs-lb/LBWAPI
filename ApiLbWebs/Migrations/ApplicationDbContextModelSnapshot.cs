﻿// <auto-generated />
using System;
using ApiLbWebs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiLbWebs.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApiLbWebs.Models.LBAcces", b =>
                {
                    b.Property<int>("idlb")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("acc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkWp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passWd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userWp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idlb");

                    b.ToTable("LBAcces");
                });

            modelBuilder.Entity("ApiLbWebs.Models.LBMail", b =>
                {
                    b.Property<int>("idlbmail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dnommail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lnkmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mailuser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passmail")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idlbmail");

                    b.ToTable("LBMail");
                });

            modelBuilder.Entity("ApiLbWebs.Models.clidev", b =>
                {
                    b.Property<int>("idev")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("acc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("icli")
                        .HasColumnType("int");

                    b.Property<string>("linkdev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userwd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("wdpins")
                        .HasColumnType("bit");

                    b.HasKey("idev");

                    b.HasIndex("icli");

                    b.ToTable("clidev");
                });

            modelBuilder.Entity("ApiLbWebs.Models.cliftp", b =>
                {
                    b.Property<int>("iftp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ipserver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passftp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userftp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iftp");

                    b.ToTable("cliftp");
                });

            modelBuilder.Entity("ApiLbWebs.Models.clihos", b =>
                {
                    b.Property<int>("ihos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime4");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("linkwphos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passhos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userhos")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ihos");

                    b.ToTable("clihos");
                });

            modelBuilder.Entity("ApiLbWebs.Models.clilb", b =>
                {
                    b.Property<int>("icli")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dnom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dnommail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dobs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("est")
                        .HasColumnType("int");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("iftp")
                        .HasColumnType("int");

                    b.Property<int?>("ihos")
                        .HasColumnType("int");

                    b.Property<int?>("ipredis")
                        .HasColumnType("int");

                    b.Property<string>("tcli")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("icli");

                    b.HasIndex("iftp");

                    b.HasIndex("ihos");

                    b.HasIndex("ipredis");

                    b.ToTable("clilb");
                });

            modelBuilder.Entity("ApiLbWebs.Models.prediscli", b =>
                {
                    b.Property<int>("ipredis")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bouby")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("envcli")
                        .HasColumnType("bit");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("paid")
                        .HasColumnType("bit");

                    b.Property<int>("pctheme")
                        .HasColumnType("int");

                    b.Property<string>("ptheme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("themebuy")
                        .HasColumnType("bit");

                    b.HasKey("ipredis");

                    b.ToTable("prediscli");
                });

            modelBuilder.Entity("ApiLbWebs.Models.usermod", b =>
                {
                    b.Property<int>("imod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dnommod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("imod");

                    b.ToTable("usermod");
                });

            modelBuilder.Entity("ApiLbWebs.Models.userop", b =>
                {
                    b.Property<int>("iuserop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dnommod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("iMod")
                        .HasColumnType("int");

                    b.HasKey("iuserop");

                    b.HasIndex("iMod");

                    b.ToTable("userop");
                });

            modelBuilder.Entity("ApiLbWebs.Models.userrol", b =>
                {
                    b.Property<int>("irol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dnomrol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("irol");

                    b.ToTable("userrol");
                });

            modelBuilder.Entity("ApiLbWebs.Models.userslb", b =>
                {
                    b.Property<int>("iduser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Rolirol")
                        .HasColumnType("int");

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("cyuscusualt")
                        .HasColumnType("datetime");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("irol")
                        .HasColumnType("int");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("iduser");

                    b.HasIndex("Rolirol");

                    b.ToTable("userslb");
                });

            modelBuilder.Entity("ApiLbWebs.Models.usrrolop", b =>
                {
                    b.Property<int>("iusrrolop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cusualt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cusumod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("faltrto")
                        .HasColumnType("datetime");

                    b.Property<string>("fmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hmod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("irol")
                        .HasColumnType("int");

                    b.Property<int>("iuserop")
                        .HasColumnType("int");

                    b.HasKey("iusrrolop");

                    b.HasIndex("irol");

                    b.HasIndex("iuserop");

                    b.ToTable("usrrolop");
                });

            modelBuilder.Entity("ApiLbWebs.Models.clidev", b =>
                {
                    b.HasOne("ApiLbWebs.Models.clilb", "Client")
                        .WithMany()
                        .HasForeignKey("icli")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiLbWebs.Models.clilb", b =>
                {
                    b.HasOne("ApiLbWebs.Models.cliftp", "Ftp")
                        .WithMany()
                        .HasForeignKey("iftp");

                    b.HasOne("ApiLbWebs.Models.clihos", "Host")
                        .WithMany()
                        .HasForeignKey("ihos");

                    b.HasOne("ApiLbWebs.Models.prediscli", "PreDis")
                        .WithMany()
                        .HasForeignKey("ipredis");
                });

            modelBuilder.Entity("ApiLbWebs.Models.userop", b =>
                {
                    b.HasOne("ApiLbWebs.Models.usermod", "Modul")
                        .WithMany()
                        .HasForeignKey("iMod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiLbWebs.Models.userslb", b =>
                {
                    b.HasOne("ApiLbWebs.Models.userrol", "Rol")
                        .WithMany()
                        .HasForeignKey("Rolirol");
                });

            modelBuilder.Entity("ApiLbWebs.Models.usrrolop", b =>
                {
                    b.HasOne("ApiLbWebs.Models.userrol", "Rol")
                        .WithMany()
                        .HasForeignKey("irol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiLbWebs.Models.userop", "Operacion")
                        .WithMany()
                        .HasForeignKey("iuserop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
