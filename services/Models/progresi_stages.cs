using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace services.Models
{
    public class progresi_stages
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string title { get; set; }
        public string tips { get; set; }
        public int order { get; set; }

        //Navigation members
        public progresi_bunches bunches { get; set; }
        public int buinch_id { get; set; }

        public ICollection<progresi_tasks> tasks { get; set; }
    }
}