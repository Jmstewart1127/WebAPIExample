using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    [Table("Todo")]
    public class Todo
    {
        [Key]
        public long Id { get; set; }
        [Required, MaxLength(255)]
        public string Description { get; set; }
        public bool IsComplete { get; set; }
    }
}
