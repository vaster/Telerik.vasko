using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School.Models
{
    public class Mark
    {
        private int id;
        private int value;
        private string subject;
        private Student student;

        public Mark()
        {
            this.id = 0;
            this.value = 0;
            this.subject = null;
            this.student = null;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public string Subject
        {
            get { return this.subject; }
            set { this.subject = value; }
        }

        public virtual Student Student
        {
            get { return this.student; }
            set { this.student = value; }
        }
    }
}
