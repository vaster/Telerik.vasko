// <copyright file="MainCore.cs" company="Anonymous">
//      Copyright statement. All right reserved.
// <author>Me</author>
// </copyright>
namespace CSharpCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The entry point for the application.
    /// </summary>
    public class MainCore
    {
        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        private static void Main(string[] args)
        {
            while (Engine.ExecuteNextCommand())
            {
                Console.WriteLine(HistoryOfPerformedActions.Output);
            }
        }
    }
}
