using System;

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
