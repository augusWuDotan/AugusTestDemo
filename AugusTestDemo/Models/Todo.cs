﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AugusTestDemo.Models
{
    public class Todo
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string DescriptionNote { get; set; }

        [Display(Name = "Created Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; }
    }
}
