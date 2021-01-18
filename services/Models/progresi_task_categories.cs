using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace services.Models
{
  public class progresi_task_categories
  {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [ForeignKey("category_id")]
        public progresi_categories category { get; set; }
        public int category_id { get; set; }

        [ForeignKey("task_id")]
        public progresi_tasks task { get; set; }
        public int task_id { get; set; }
    }
}