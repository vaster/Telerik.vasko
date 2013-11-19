using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Disciplines
    {
        private string disciplineName;
        private int lecturePerWeek;
        private int exercisesPerWeek;

        //constructor
        public Disciplines(string disciplineName, int lecturePerWeek, int exercisesPerWeek)
        {
            this.DisciplineName = disciplineName;
            this.LectirePerWeek = lecturePerWeek;
            this.ExercisesPerWeek = exercisesPerWeek;
        }

        //properties
        private string DisciplineName
        {
            get { return this.disciplineName; }
            set { this.disciplineName = value; }
        }

        private int LectirePerWeek
        {
            get { return this.lecturePerWeek; }
            set { this.lecturePerWeek = value; }
        }

        private int ExercisesPerWeek
        {
            get { return this.exercisesPerWeek; }
            set { this.exercisesPerWeek = value; }
        }

        public override string ToString()
        {
            return String.Format(" |Subject Name: {0}{1} |Lectures for a week: {2}{3} |Exercises for a week: {4}{5}",
                this.DisciplineName,
                Environment.NewLine,
                this.LectirePerWeek,
                Environment.NewLine,
                this.ExercisesPerWeek,
                Environment.NewLine);
        }
    }
}
