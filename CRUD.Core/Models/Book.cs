using System.ComponentModel.DataAnnotations;

namespace CRUD.Core.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required, MaxLength(250)]
        public string Title { get; set; }

        public Author Author { get; set; }

        public int AuthorId { get; set; }
    }
}
