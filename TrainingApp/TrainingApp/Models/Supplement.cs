using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrainingApp.Models
{
    public class Supplement
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(10)]
        public string MethodOfAdmin { get; set; }
        public int Dose { get; set; }
        [StringLength(10)]
        public string MeasuringUnit { get; set; }
        public DateTime DateAdded { get; set; }

    }
}