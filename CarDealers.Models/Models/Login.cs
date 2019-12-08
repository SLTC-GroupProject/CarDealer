using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CarDealers.Models.Models
{
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
        public int UserId { get; set; }

    }
}
