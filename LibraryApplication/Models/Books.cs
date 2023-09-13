using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryApplication.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kitap adı gereklidir.")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "Yazarı gereklidir.")]
        public string Writer { get; set; }

        [Required(ErrorMessage = "Resim gereklidir.")]
        public string ImageURL { get; set; }

        public string Location { get; set; }
        public string Customer { get; set; }
        public DateTime? Backtime { get; set; }
    }
}
