using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Banking2.Models
{
    public class RegisterModel
    {
        public long Account_No { get; set; }
        public string Account_Name { get; set; }
        public long Mobile_No { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        public string Address { get; set; }
        public string Bank_Branch { get; set; }
        public string IFSC { get; set; }
    }
}