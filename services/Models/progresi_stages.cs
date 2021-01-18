using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace services.Models
{
    public class progresi_stages
    {
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