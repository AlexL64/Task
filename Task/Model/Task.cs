using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Model
{
    public class Task
    {
        public string? Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public DateTime Created { get; set; }

        public string? Status { get; set; }
    }

}
