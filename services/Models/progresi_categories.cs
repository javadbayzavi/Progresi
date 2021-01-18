using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace services.Models
{
  public class progresi_categories
  {
        [Key]
        public int Id { set; get; }
        [Required]
        public string title { get; set; }

        public ICollection<progresi_bunch_categories> bunches { get; set; }
        public ICollection<progresi_task_categories> tasks { get; set; }
    }
}