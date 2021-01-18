using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace services.Models
{
  public class progresi_bunches
  {
        public int Id { set; get; }
        public string title { get; set; }
        public string tips { get; set; }

        public ICollection<progresi_categories> categories { get; set; }
    }
}