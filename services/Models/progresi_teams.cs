using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace services.Models
{
  public class progresi_teams
  {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string title { get; set; }
        public string tips { get; set; }
        
        //Navigation members
        public progresi_bunches bunches { get; set; }
        public int buinch_id { get; set; }
      
  }
}