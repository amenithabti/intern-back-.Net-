using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_App.Models
{
    public class Formateur
    {
        [Key]

        public int Id { get; set; }
        [Column(TypeName = "nvarchar(30)")]

        public string email { get; set; }

        [Column(TypeName = "nvarchar(30)")]

        public string fullname { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string phonenumber { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string nationality { get; set; }


    }
}
