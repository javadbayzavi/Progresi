using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace services.Models
{
  public class progresi_bunches
  {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        public string title { get; set; }
        public string tips { get; set; }

        public ICollection<progresi_stages> stages { get; set; }
        public ICollection<progresi_categories> categories { get; set; }
    }
}