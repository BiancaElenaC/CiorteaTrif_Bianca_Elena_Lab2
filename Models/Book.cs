using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace CiorteaTrif_Bianca_Elena_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]

        //Laborator 6 Sarcina 2
        [Required(ErrorMessage = "Este obligatoriu sa fie introdus titlul cartii!")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul cartii trebuie sa contina intre 3 si 150 de caractere.")]
        public string Title { get; set; }
        //public string Author { get; set; }
        //[Column(TypeName = "decimal(6, 2)")]
        [Column(TypeName = "decimal(6, 2)")] [Range(0.01, 500)]
        public decimal Price { get; set; }
        // [DataType(DataType.Date)]
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }
        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        public ICollection<Borrowing>? Borrowings { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
