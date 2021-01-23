using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace services.Models
{
  public class progresi_users
  {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string name { get; set; }
        public string family { get; set; }
        public string username { get; set; }
        public int authmode { get; set; }
        public int last_access { get; set; }
        public int create_date { get; set; }
        public int status { get; set; }

        public ICollection<progresi_user_teams> teams { get; set; }
        public ICollection<progresi_task_assigns> tasks { get; set; }
    }
}