using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem
{
    // a variant with indexer for joining participants and method for excluding
    // used generics for code reusability in diffrenet cases.
    public class Course<T>
        where T : Student
    {
        private const int MAX_PARTICIPANTS = 30;
        private int currentParticipantCount;

        private T[] courseParticipants;

        // constructor
        public Course()
        {
            this.CurrentParticipantCount = 0;
            this.courseParticipants = new T[Course<T>.MAX_PARTICIPANTS];

        }

        // methods
        public void ExcludeParticipant(T participant)
        {
            
            for (int currIndex = 0; currIndex < this.CurrentParticipantCount; currIndex++)
            {
                Console.WriteLine(currIndex);
                if (this.courseParticipants[currIndex].UniqeNumber == participant.UniqeNumber)
                {
                    this.courseParticipants[currIndex] = null;
                    this.CurrentParticipantCount--;
                    break;
                }
            }

            int indexOfNullObject = 0;
            int indexOfNonNullObject = 0;

            // fill excluded or 'null' objects by re-arrange the array
            while (true)
            {
                for (int currIndex = indexOfNullObject; currIndex < Course<T>.MAX_PARTICIPANTS; currIndex++)
                {
                    if (this.courseParticipants[currIndex] == null)
                    {
                        indexOfNullObject = currIndex;
                        break;
                    }  
                }

                for (int currIndex = indexOfNullObject; currIndex < Course<T>.MAX_PARTICIPANTS; currIndex++)
                {
                    if (this.courseParticipants[currIndex] != null)
                    {
                        indexOfNonNullObject = currIndex;   
                        break;
                    }
                }

                if (indexOfNonNullObject > indexOfNullObject)
                {
                    this.courseParticipants[indexOfNullObject] = this.courseParticipants[indexOfNonNullObject];
                    this.courseParticipants[indexOfNonNullObject] = null;
                }

                else
                {
                    break;
                }
            }
        }

        // indexer for joining students
        public T this[int index]
        {
            get
            {
                // check for invalid index
                if (index < 0 || index >= Course<T>.MAX_PARTICIPANTS)
                {
                    throw new ArgumentOutOfRangeException(String.Format(
                        "Invalid course member index! Index must in range from 0 - 29. Index = {0}",
                        index));
                }
                return this.courseParticipants[index];
            }
            set
            {
                // check for invalid index
                if (index < 0 || index >= Course<T>.MAX_PARTICIPANTS)
                {
                    throw new ArgumentOutOfRangeException
                        (String.Format("Invalid course member index! Index must in range from 0 - 29. Index = {0}",index));
                }


                // this will prevent if someone try to rewrite allready existing participant with new and will not allow 'null' a participent. Allowed only in exclude method.
                if (this.courseParticipants[index] != null)
                {
                    throw new InvalidOperationException("There is existing participant at this index you're trying to set!");
                }

                if (this.CurrentParticipantCount < Course<T>.MAX_PARTICIPANTS)
                {
                    this.CurrentParticipantCount++;
                    this.courseParticipants[index] = value;
                }
              

                   // check for participant that has allready joined the course
                for (int currIndex = 0; currIndex < this.CurrentParticipantCount; currIndex++)
                {
                    if (currIndex != index)
                    {
                        if (this.courseParticipants[index].UniqeNumber == this.courseParticipants[currIndex].UniqeNumber)
                        {
                            throw new ArgumentException
                                (String.Format("Student with School number {0} already exist in this course!",
                                                this.courseParticipants[index].UniqeNumber));
                        }
                    }
                }

            }

        }

        // properties

        private int CurrentParticipantCount
        {
            get
            {
                return this.currentParticipantCount;
            }
            set
            {
                this.currentParticipantCount = value;
            }
        }
    }
}
