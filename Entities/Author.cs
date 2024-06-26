﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksAPI.Entities
{
    [Table("Authors")]
    public class Author
    {
        public Author(Guid id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; } 
    }
}
