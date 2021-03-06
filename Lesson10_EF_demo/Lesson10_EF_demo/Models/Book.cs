﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson10_EF_demo.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime PublishedOn { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
