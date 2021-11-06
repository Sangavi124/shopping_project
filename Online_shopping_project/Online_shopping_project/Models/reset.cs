using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_shopping_project.Models
{
    public class reset
    {
        public int id { get; set; }
        [Required]

        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Password mismatch")]
        public string ConfirmPassword { get; set; }
    }
}