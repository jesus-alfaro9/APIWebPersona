using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCrudWebAPi.Models
{
    public class Reply
    {
        public int Result { get; set; }
        public object data { get; set; }
        public string message { get; set; }

    }
}