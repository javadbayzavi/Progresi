using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace services.Models
{
    public partial class progressi_stage_tasks
    {
      [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public int ID { get; set; }
      
      [ForeignKey("stages_id")]
      public progress_stages stage { get; set; }
      public int stage_id { get; set; }
      
      [ForeignKey("task_id")]
      public progresi_task { get; set; }
      public int task_id { get; set; }
      
      public int changetime { get; set; }
      
      [ForeignKey("user_id")] 
      public progresi_user planner { get; set; }
      public int user_id { get; set; }
    }
}