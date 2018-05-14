using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManager.Models
{
    public class Category
    {
        [Required]
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}