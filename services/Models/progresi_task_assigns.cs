using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace services.Models
{
  public class progresi_task_assign
  {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [ForeignKey("user_id")]
        public progresi_users user { get; set; }
        public int user_id { get; set; }

        [ForeignKey("task_id")]
        public progresi_tasks task { get; set; }
        public int task_id { get; set; }

        public int assigndate { get; set; }

        public string assignComment { get; set; }
    }
}