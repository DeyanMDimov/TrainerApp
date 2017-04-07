using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using TrainingApp.Models;

namespace TrainingApp.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(1)]
        public string Sex { get; set; }
        public int Weight { get; set; }
        public DateTime JoinDate { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
    }
}