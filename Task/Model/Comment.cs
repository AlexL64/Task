using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Comment
    {
        public string? id { get; set; }

        public string? task { get; set; }

        public string? text { get; set; }

        public DateTime created { get; set; }
    }
}
