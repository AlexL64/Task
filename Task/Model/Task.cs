using System;

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
