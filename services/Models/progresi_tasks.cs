using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace services.Models
{
    public class progresi_tasks
    {
        public int Id { get; set; }
        public string title { get; set; }
        public string tips { get; set; }
        public int priority { get; set; }
        public int createddate { get; set; }
        public int lastmodified { get; set; }

        //Navigation members
        public progresi_bunches bunches { get; set; }
        public int buinch_id { get; set; }

        public ICollection<progresi_categories> categories { get; set; }
    }
}