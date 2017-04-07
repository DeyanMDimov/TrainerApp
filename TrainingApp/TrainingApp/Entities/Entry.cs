using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TrainingApp.Entities
{
    public class Entry
    {

        public int EntryID { get; set; }
        public int Amount { get; set; }
        public DateTime dateAdded { get; set; }
        public Supplement Supplement { get; set; }
        [Required]
        public int SupplementID { get; set; }
        public Person Person { get; set; }
        [Required]
        public int UserId { get; set; }
        public DateTime TimeIngested { get; set; }

    }
}