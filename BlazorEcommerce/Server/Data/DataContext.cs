namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "First and Last and Always",
                    Description = "First and Last and Always is the debut studio album by English gothic rock band the Sisters of Mercy. It was released on 11 March 1985 through the band's self-financed Merciful Release label.",
                    ImageURL = "https://m.media-amazon.com/images/I/5170MWXHA4L._UF1000,1000_QL80_.jpg",
                    Price = 9.99m
                },

                new Product
                {
                    Id = 2,
                    Title = "The Sky's Gone Out",
                    Description = "The Sky's Gone Out is the third studio album by English gothic rock band Bauhaus, released in 1982 by record label Beggars Banquet.",
                    ImageURL = "https://i.discogs.com/o3yzAi_CocgxqKVAC8bIw8x6PeKGL1BoTPFaRKgGers/rs:fit/g:sm/q:90/h:600/w:599/czM6Ly9kaXNjb2dz/LWRhdGFiYXNlLWlt/YWdlcy9SLTM4MjIx/MC0xNDE3NzQwNjAx/LTk1NjIuanBlZw.jpeg",
                    Price = 8.99m
                },

                new Product
                {
                    Id = 3,
                    Title = "Pornography",
                    Description = "Pornography is the fourth studio album by English Gothic rock band The Cure, released on 3 May 1982 by Fiction Records. Preceded by the non-album single 'Charlotte Sometimes', it was the band's first album with new producer Phil Thornalley, and was recorded at RAK Studios from January to April 1982.",
                    ImageURL = "https://www.udiscovermusic.com/wp-content/uploads/2016/09/Tthe-Cure-Pornography-album-cover-web-optimised-820.jpg",
                    Price = 7.99m
                }

                );
        }
    }
}
