using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace services.Models
{
  public class progresi_categories
  {
        [Key]
        public int Id { set; get; }
        [Required]
        public string title { get; set; }
    }
}