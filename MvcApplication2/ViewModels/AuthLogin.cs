using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleBlog.ViewModel
{
    public class AuthLogin
    {
        [Required, DataType(DataType.Text)]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public Int32 Password { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}