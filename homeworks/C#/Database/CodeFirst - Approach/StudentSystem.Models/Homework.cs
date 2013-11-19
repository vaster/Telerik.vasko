using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem.Models
{
    public class Homework
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}
