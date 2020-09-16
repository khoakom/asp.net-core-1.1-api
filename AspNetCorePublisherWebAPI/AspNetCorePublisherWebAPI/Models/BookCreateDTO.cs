﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCorePublisherWebAPI.Models
{
    public class BookCreateDTO
    {
        [Required(ErrorMessage = "You must enter a title")]
        [MaxLength(50)]
        public string Title { get; set; }
        public int PublisherId { get; set; }
    }
}
