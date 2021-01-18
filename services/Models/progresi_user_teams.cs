using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace services.Models
{
  public class progresi_user_teams
  {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        [ForeignKey("user_id")]
        public progresi_users user { get; set; }
        public int user_id { get; set; }

        [ForeignKey("team_id")]
        public progresi_teams team { get; set; }
        public int team_id { get; set; }

        public int joindate { get; set; }
    }
}