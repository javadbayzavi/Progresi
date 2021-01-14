using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace services.Models
{
  public class progresi_teams
  {
        public int Id { set; get; }
        public string title { get; set; }
        public string tips { get; set; }
        
        //Navigation members
        public progresi_bunches bunches { get; set; }
        public int buinch_id { get; set; }
      
  }
}