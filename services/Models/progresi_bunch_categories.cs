using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace services.Models
{
  public class progresi_bunch_categories
  {
        [Key]
        public int Id { set; get; }

        [ForeignKey("category_id")]
        public progresi_categories category { get; set; }
        public int category_id { get; set; }

        [ForeignKey("bunch_id")]
        public progresi_bunches bunch { get; set; }
        public int bunch_id { get; set; }
    }
}