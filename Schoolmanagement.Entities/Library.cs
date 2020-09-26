using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Schoolmanagement.Entities
{
    public class Library
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Publication { get; set; }
        public string Writer { get; set; }
        public int Stock { get; set; }
    }
}
