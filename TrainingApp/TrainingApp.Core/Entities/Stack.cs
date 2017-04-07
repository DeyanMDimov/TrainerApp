using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrainingApp.Entities
{
    public class Stack
    {
        public int StackID { get; set; }
        [Required]
        [StringLength(50)]
        public string StackName { get; set; }
        [Required]
        public int UserID { get; set; }
        public DateTime dateAdded { get; set; }
        public IList<Supplement> SupplementIDs { get; set; }

    }
}