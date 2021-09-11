using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_App.Models
{
    public class User 
    {
        [Key]

        public int Id { get; set; }
        [Column(TypeName = "nvarchar(30)")]

        public string username { get; set; }

        [Column(TypeName = "nvarchar(30)")]

        public string password { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string FullName { get; set; }

    }
}
