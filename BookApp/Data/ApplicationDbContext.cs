using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookApp.Models;

namespace BookApp.Data
{
    public class ApplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers {  get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                       Id = 1,
                       Title= "The Night Circus",
                       Description= "A tale of magic, love, and rivalry set in a mysterious circus that only opens at night. Celia and Marco are bound in a competition of enchantments, with the fate of the circus at stake.",
                       ISBN= "978-0385534635",
                       Author= "Erin Morgenstern",
                       Price = "15.99",
                       Image= "Images/nightcircus.jpg"

                },
                new Product 
                {
                    Id= 2,
                    Title= "Sapiens: A Brief History of Humankind",
                    Description = "This book explores the history of humans from the Stone Age to the modern era, examining how biology and history have defined us and how we can shape the future.",
                    ISBN = "978-0062316097",
                    Author= "Yuval Noah Harari",
                    Price = "18.00  ",
                    Image= "Images/sapiens.jpg"
                },
                new Product
                {
                    Id = 3,
                    Title = "Dune",
                    Description = " A science fiction epic about Paul Atreides, who must navigate political intrigue and conflict over the desert planet Arrakis, the only source of the most valuable substance in the universe.",
                    ISBN = "978-0441013593",
                    Author = "Frank Herbert",
                    Price = "9.99",
                    Image= "Images/duneillustrated-scaled.jpeg"
                },
            new Product
            {
                Id = 4,
                Title = "The Diary of a Young Girl",
                Description = "A poignant diary chronicling the life of a Jewish girl hiding during the Holocaust, reflecting her thoughts, dreams, and fears during a time of great turmoil.",
                ISBN = "978-0553296983",
                Author = "Anne Frank",
                Price = "7.99",
                Image= "Images/Dairy-Girl.jpg"
            },
            new Product
            {
                Id = 5,
                Title = "The Girl with the Dragon Tattoo",
                Description = "A gripping thriller involving journalist Mikael Blomkvist and hacker Lisbeth Salander as they unravel the mystery of a missing girl from a powerful family.",
                ISBN = "978-0307454546",
                Author = "Stieg Larsson",
                Price = "12.99",
                Image= "Images/the_girl_with_the_dragon_tattoo.jpg"
            },
            new Product
            {
                Id = 6,
                Title = "The Name of the Wind",
                Description = "The first book in The Kingkiller Chronicle, it follows Kvothe, a gifted young man who grows up to be a legendary figure, as he recounts his life story filled with magic, music, and adventure.",
                ISBN = "978-0756404741",
                Author = "Patrick Rothfuss",
                Price = "15.95",
                Image= "Images/the_name_of_wind.jpg"
            },
            new Product
            {
                Id = 7,
                Title = "The Book Thief",
                Description = "Set in Nazi Germany, it tells the story of a young girl named Liesel who finds solace in stealing books and sharing them with others, including the Jewish man hiding in her basement.",
                ISBN = "978-0375842207",
                Author = "Markus Zusak",
                Price = "14.99",
                Image = "Images/the_book_thief.jpeg"
            },
            new Product
            {
                Id = 8,
                Title = "Atomic Habits",
                Description = " A practical guide to building good habits and breaking bad ones, this book emphasizes the power of small changes that lead to significant results over time.",
                ISBN = "978-0735211292",
                Author = "James Clear",
                Price = "24.95",
                Image = "Images/Atomic_Habits.png"
            },
            new Product
            {
                Id = 9,
                Title = "The Sun and Her Flowers",
                Description = "A collection of poems celebrating love, loss, trauma, and healing, this book is known for its powerful messages and accompanying illustrations.",
                ISBN = "978-1449486792",
                Author = "Rupi Kaur",
                Price = "14.99",
                Image = "Images/the_sun_and_her_flower.png"
            },
            new Product
            {
                Id = 10,
                Title = "The Hate U Give",
                Description = "A compelling novel about Starr Carter, a teenage girl who witnesses the police shooting of her friend and grapples with issues of race, identity, and activism.",
                ISBN = "978-0062498533",
                Author = "Angie Thomas",
                Price = "12.99",
                Image = "Images/The-Hate-U-Give-cover-768x768.jpg"
            }
            );
        }

    }
}
