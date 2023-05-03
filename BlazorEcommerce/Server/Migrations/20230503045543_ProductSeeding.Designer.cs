﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230503045543_ProductSeeding")]
    partial class ProductSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "First and Last and Always is the debut studio album by English gothic rock band the Sisters of Mercy. It was released on 11 March 1985 through the band's self-financed Merciful Release label.",
                            ImageURL = "https://m.media-amazon.com/images/I/5170MWXHA4L._UF1000,1000_QL80_.jpg",
                            Price = 9.99m,
                            Title = "First and Last and Always"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The Sky's Gone Out is the third studio album by English gothic rock band Bauhaus, released in 1982 by record label Beggars Banquet.",
                            ImageURL = "https://i.discogs.com/o3yzAi_CocgxqKVAC8bIw8x6PeKGL1BoTPFaRKgGers/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM4MjIx/MC0xNDE3NzQwNjAx/LTk1NjIuanBlZw.jpeg",
                            Price = 8.99m,
                            Title = "The Sky's Gone Out"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Pornography is the fourth studio album by English Gothic rock band The Cure, released on 3 May 1982 by Fiction Records. Preceded by the non-album single 'Charlotte Sometimes', it was the band's first album with new producer Phil Thornalley, and was recorded at RAK Studios from January to April 1982.",
                            ImageURL = "https://www.udiscovermusic.com/wp-content/uploads/2016/09/Tthe-Cure-Pornography-album-cover-web-optimised-820.jpg",
                            Price = 7.99m,
                            Title = "Pornography"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
