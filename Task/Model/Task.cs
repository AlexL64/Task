using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Task
    {
        public string? id { get; set; }

        public string? title { get; set; }

        public string? description { get; set; }

        public DateTime created { get; set; }

        public string? status { get; set; }
    }

}
