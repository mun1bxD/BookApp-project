using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookApp.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTableWithSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Author", "Description", "ISBN", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Erin Morgenstern", "A tale of magic, love, and rivalry set in a mysterious circus that only opens at night. Celia and Marco are bound in a competition of enchantments, with the fate of the circus at stake.", "978-0385534635", "Images/nightcircus.jpg", "15.99", "The Night Circus" },
                    { 2, "Yuval Noah Harari", "This book explores the history of humans from the Stone Age to the modern era, examining how biology and history have defined us and how we can shape the future.", "978-0062316097", "Images/sapiens.jpg", "18.00  ", "Sapiens: A Brief History of Humankind" },
                    { 3, "Frank Herbert", " A science fiction epic about Paul Atreides, who must navigate political intrigue and conflict over the desert planet Arrakis, the only source of the most valuable substance in the universe.", "978-0441013593", "Images/duneillustrated-scaled.jpeg", "9.99", "Dune" },
                    { 4, "Anne Frank", "A poignant diary chronicling the life of a Jewish girl hiding during the Holocaust, reflecting her thoughts, dreams, and fears during a time of great turmoil.", "978-0553296983", "Images/Dairy-Girl.jpg", "7.99", "The Diary of a Young Girl" },
                    { 5, "Stieg Larsson", "A gripping thriller involving journalist Mikael Blomkvist and hacker Lisbeth Salander as they unravel the mystery of a missing girl from a powerful family.", "978-0307454546", "Images/the_girl_with_the_dragon_tattoo.jpg", "12.99", "The Girl with the Dragon Tattoo" },
                    { 6, "Patrick Rothfuss", "The first book in The Kingkiller Chronicle, it follows Kvothe, a gifted young man who grows up to be a legendary figure, as he recounts his life story filled with magic, music, and adventure.", "978-0756404741", "Images/the_name_of_wind.jpg", "15.95", "The Name of the Wind" },
                    { 7, "Markus Zusak", "Set in Nazi Germany, it tells the story of a young girl named Liesel who finds solace in stealing books and sharing them with others, including the Jewish man hiding in her basement.", "978-0375842207", "Images/the_book_thief.jpeg", "14.99", "The Book Thief" },
                    { 8, "James Clear", " A practical guide to building good habits and breaking bad ones, this book emphasizes the power of small changes that lead to significant results over time.", "978-0735211292", "Images/Atomic_Habits.png", "24.95", "Atomic Habits" },
                    { 9, "Rupi Kaur", "A collection of poems celebrating love, loss, trauma, and healing, this book is known for its powerful messages and accompanying illustrations.", "978-1449486792", "Images/the_sun_and_her_flower.png", "14.99", "The Sun and Her Flowers" },
                    { 10, "Angie Thomas", "A compelling novel about Starr Carter, a teenage girl who witnesses the police shooting of her friend and grapples with issues of race, identity, and activism.", "978-0062498533", "Images/The-Hate-U-Give-cover-768x768.jpg", "12.99", "The Hate U Give" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
