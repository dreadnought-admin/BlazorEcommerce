using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedsMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 4, "Punk", "punk" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Floodland is the second studio album by English gothic rock band the Sisters of Mercy. It was released on 16 November 1987, through Merciful Release internationally and distributed by WEA, with Elektra Records handling the United States release.", "http://s3.amazonaws.com/quietus_production/images/articles/10717/The_Sisters_of_Mercy_-_Floodland_1353248725.jpg", 17.99m, "Floodland" },
                    { 5, 1, "There are only a few albums that could be cited as a pivotal moment in dark music over the past decade, and one of them would be she past away’s belirdi gece (which translates to “the night appeared”) from 2012. It could be said that the 2010s wave of the darkwave genre is defined by this lp, a monumental component to the scene’s landscape. The album—written by volkan caner, idris akbulut, and doruk öztürkcan from bursa, turkey—appeared from nowhere and slowly crept up on unsuspecting fans of the genre. Immediately, she past away felt like a reincarnation of sisters of mercy with their snappy drum machine underneath caner’s bellowing vocals sung in turkish. Or, further, she past away is the long lost child of 1980s post-punk bands such as clan of xymox, joy division, and the cure. \r\n    But it would be too easy to compare them to classic, old-guard bands. Belirdi gece has become a staple in the genre itself, the ignition to a slew of bands that aim for the same mood and distinct sound that has become spa’s very own. This lp was just the beginning of the band’s rise into the darkwave zeitgeist—a great accomplishment for any band, especially, whose lyrics are not sung in english. There is drama, mystery, and longing within this album, but it also maintains a pure danceability. These are tracks for the goth club, full of classics that go hand-in-hand with the progenitors of the movement. \r\n    While most tracks on belirdi gece feel familiar, it’s because you can’t escape them. Nightclubs around the world rely on the songs to keep dancefloors crammed into the early hours of morning. “sanri,” the opening song, is an unmistakable classic that brings on waves of sadness and a spooky atmosphere that remains throughout the lp. Another recognizable classic is “ritüel” that is shrouded in mystery (most of all by the ghostly whispers that haunt the track) and led by a prominent, demanding guitar line. “monoton” is just as its song title suggests: a feeling of melancholy, a projection of the hopelessness of life that’s viewed in a monotone black and white. The song “kasvetli kutlama” is another dance floor diamond, perfect for smoke-filled basements, while “insanlar” pulls back on the dramatics and derives its melody and atmosphere from traditional forms of post-punk, complete with haunting vocals that brim with longing. \r\n    With its minimal wave attributes, “belirdi gece (musallat)” is melodramatic and awash in darkness. “ruh”—a track with an insatiable beat—progresses into an epic resolution as caner’s vocals echo and call out into the black night sky. The eeriness of “kemir beni” recalls a strange feeling of anticipation with its synthpunk beat and running synths while “bozbulanik” continues on with a sense of dread, an urgency. Belirdi gece closes out with “ice kapanis,” a proper ending to the severity of the album, akin to the cure’s signature death march à la seventeen seconds. She past away’s first full length introduced the scene to their own style of funeral dance—one full of tumultuous emotions—that was not only fun to dance to, but altered darkwave’s dna. \r\n    We present you the 10th anniversary limited edition of “belirdi gece”. Black on black cover design and semi black semi clear vinyl are the main features of this celebratory edition.\",\r\n    record_labels: \"Fabrika Records", "https://fabrikarecords.com/wp-content/uploads/2020/08/FP008-FRONT-1200-768x768.png", 4.99m, "Belirdi Gece" },
                    { 6, 3, "Medusa is the second studio album by Dutch dark wave band Clan of Xymox. It was released on 1 November 1986 by 4AD. Founding member Pieter Nooten re-recorded the songs 'After the Call' and 'Theme I' on Sleeps with the Fishes, his 1987 collaborative album with Michael Brook, following a brief split from the band.", "https://i.pinimg.com/originals/27/9b/0f/279b0ff6a7d6654f52d18399feee06d6.jpg", 7.99m, "Medusa" },
                    { 7, 2, "Killing Joke is the debut studio album by English post-punk band Killing Joke, released on 5 October 1980 by E.G. via Polydor Records. It debuted at number 41 on the UK Albums Chart on 26 October 1980 and later peaked at number 39.", "https://rockandrollglobe.com/wp-content/uploads/2020/11/image3A18231_Glitch3.jpg", 10.99m, "Killing Joke" },
                    { 8, 4, "...If I Die, I Die is the debut studio album by Irish rock band Virgin Prunes. It was released on 4 November 1982 by record label Rough Trade. It was produced by Colin Newman of Wire.", "https://www.virginprunes.com/wp/wp-content/uploads/Virgin-Prunes-If-I-Die-I-Die-sleeve-600x600-1.png", 5.99m, "... If I Die, I Die" },
                    { 9, 4, "Curse is the seventh studio album by English gothic rock band Alien Sex Fiend, released in September 1990 by Anagram Records", "https://i.discogs.com/o8pmtWn5ISkt8ieSx-VsskGWzpYlHayLt8n7bMYsKOk/rs:fit/g:sm/q:90/h:600/w:596/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTYyODYx/Ni0xMTk5MjA0ODE0/LmpwZWc.jpeg", 3.99m, "Curse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
