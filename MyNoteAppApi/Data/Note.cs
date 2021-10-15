using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyNoteAppApi.Data
{
    public class Note
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
        public DateTime? CreateTime { get; set; } = DateTime.Now;
        public DateTime? ModifiedTime { get; set; } 
    }
}
