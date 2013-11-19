// <copyright file="HistoryOfPerformedActions.cs" company="Anonymous">
//      Copyright statement. All right reserved.
// <author>Me</author>
// </copyright>
namespace CSharpCode
{
    //// 1.Code Refactored and changed by recomendations of StyleCop tool.
    //// 2.Encapsulation - all fileds are accessed by properties.
    //// 3.Initialize new instence of the Output in a static constructor.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This class is the second half of a communication link between the program and the user.
    ///     Used to store history of performed actions. 
    /// </summary>
    public static class HistoryOfPerformedActions
    {
        // fileds

        /// <summary>
        /// <param name="output">Used to store the performed actions in the application.</param>
        /// </summary>
        private static StringBuilder output;

        // constructor

        /// <summary>
        /// Initializes static members of the <see cref="HistoryOfPerformedActions"/> class.
        /// </summary>
        static HistoryOfPerformedActions()
        {
            output = new StringBuilder();
        }

        // methods

        /// <summary>
        /// Gets or sets value for the output field.
        /// </summary>
        public static StringBuilder Output
        {
            get
            {
                return output;
            }

            set
            {
                output = value;
            }
        }
    }
}
