using System.ComponentModel.DataAnnotations;

namespace BookApp.Models
{
    public class ProductEdit
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = "Description can't be longer than 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "ISBN Required")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Author name Required")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Price Required")]
        public string Price { get; set; }

    }
}
