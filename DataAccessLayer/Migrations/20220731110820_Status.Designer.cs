﻿// <auto-generated />
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220731110820_Status")]
    partial class Status
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityLayer.Abstract.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutBirthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDegree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutExperience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("EntityLayer.Abstract.Contact", b =>
                {
                    b.Property<int>("ContactID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactSubject")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactID");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("EntityLayer.Abstract.EducationAndExpericence", b =>
                {
                    b.Property<int>("EducationAndExpericenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EducationAndExpericenceDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationAndExpericenceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationAndExpericenceLittleTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationAndExpericenceStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EducationAndExpericenceTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EducationAndExpericenceID");

                    b.ToTable("EducationAndExpericences");
                });

            modelBuilder.Entity("EntityLayer.Abstract.Link", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LinkFacebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkInstagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkLinkedin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkTwitter")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkID");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("EntityLayer.Abstract.Service", b =>
                {
                    b.Property<int>("ServicesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ServicesDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServicesTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServicesID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EntityLayer.Abstract.Skil", b =>
                {
                    b.Property<int>("SkilsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SkilsRatio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkilsTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkilsID");

                    b.ToTable("Skils");
                });
#pragma warning restore 612, 618
        }
    }
}