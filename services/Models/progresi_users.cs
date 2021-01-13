using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace services.Models
{
  public class progresi_users
  {
        public int Id { set; get; }
        public string name { get; set; }
        public string family { get; set; }
        public string username { get; set; }
        public int authmode { get; set; }
        public int last_access { get; set; }
        public int create_date { get; set; }
        public int status { get; set; }
    }
}