// <copyright file="Messages.cs" company="Anonymous">
//      Copyright statement. All right reserved.
// <author>Me</author>
// </copyright>
namespace CSharpCode
{
    //// Code Refactored and changed by recomendations of StyleCop tool.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class is the first half of a communication link between the program and the user.
    ///     Used to create history of performed actions. 
    /// </summary>
    public static class Messages
    {
        // methods

        /// <summary>
        /// Method that signalize in the print history when a Event is added.
        /// </summary>
        public static void EventAdded()
        {
            HistoryOfPerformedActions.Output.Append("Event added\n");
        }

        /// <summary>
        /// Method that signalize in the print history how many Events are deleted.
        /// </summary>
        /// <param name="x">Number of deleted Events.</param>
        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                HistoryOfPerformedActions.Output.AppendFormat("{0} events deleted\n", x);
            }
        }

        /// <summary>
        /// Method that signalize in the print history when no Events are found.
        /// </summary>
        public static void NoEventsFound()
        {
            HistoryOfPerformedActions.Output.Append("No events found\n");
        }

        /// <summary>
        /// Method that signalize in the print history for a specific Event to be printed.
        /// </summary>
        /// <param name="eventToPrint">Event to be added in the print history.</param>
        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                HistoryOfPerformedActions.Output.Append(eventToPrint + "\n");
            }
        }
    }
}
