using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "First and Last and Always is the debut studio album by English gothic rock band the Sisters of Mercy. It was released on 11 March 1985 through the band's self-financed Merciful Release label.", "https://m.media-amazon.com/images/I/5170MWXHA4L._UF1000,1000_QL80_.jpg", 9.99m, "First and Last and Always" },
                    { 2, "The Sky's Gone Out is the third studio album by English gothic rock band Bauhaus, released in 1982 by record label Beggars Banquet.", "https://i.discogs.com/o3yzAi_CocgxqKVAC8bIw8x6PeKGL1BoTPFaRKgGers/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM4MjIx/MC0xNDE3NzQwNjAx/LTk1NjIuanBlZw.jpeg", 8.99m, "The Sky's Gone Out" },
                    { 3, "Pornography is the fourth studio album by English Gothic rock band The Cure, released on 3 May 1982 by Fiction Records. Preceded by the non-album single 'Charlotte Sometimes', it was the band's first album with new producer Phil Thornalley, and was recorded at RAK Studios from January to April 1982.", "https://www.udiscovermusic.com/wp-content/uploads/2016/09/Tthe-Cure-Pornography-album-cover-web-optimised-820.jpg", 7.99m, "Pornography" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
