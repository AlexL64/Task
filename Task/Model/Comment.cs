using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Comment
    {
        public string? Id { get; set; }

        public string? Task { get; set; }

        public string? Text { get; set; }

        public DateTime Created { get; set; }
    }
}
