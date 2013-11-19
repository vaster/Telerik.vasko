using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    [ExcludeFromCodeCoverage]
    public class Command : ICommand
    {
        readonly char[] paramsSeparators = { ';' };

        readonly char commandEnd = ':';

        public CommandType Type { get; set; }

        public string OriginalForm { get; set; }

        public string Name { get; set; }

        public string[] Parameters { get; set; }

        private Int32 commandNameEndIndex;

        private const string ADD_BOOK = "Add book";
        private const string ADD_MOVIE = "Add movie";
        private const string ADD_SONG = "Add song";
        private const string ADD_APPLICATION = "Add application";
        private const string UPDATE = "Update";
        private const string FIND = "Find";

        public Command(string input)
        {
            this.OriginalForm = input.Trim();
            this.Parse();
        }

        private void Parse()
        {
            this.commandNameEndIndex = this.GetCommandNameEndIndex();
            this.Name = this.ParseName();
            this.Parameters = this.ParseParameters();
            this.TrimParams();
            this.Type = this.ParseCommandType(this.Name);
        }

        public CommandType ParseCommandType(string commandName)
        {
            if (commandName.Contains(':') || commandName.Contains(';'))
            {
                throw new FormatException(String.Format("Symbols ';' and ':' are not allowed as part of the command name. Command name:{0}.",this.Name));
            }

            switch (commandName.Trim())
            {
                case Command.ADD_BOOK:
                    Type = CommandType.AddBook;
                    break;

                case Command.ADD_MOVIE:
                    Type = CommandType.AddMovie;
                    break;

                case Command.ADD_SONG:
                    Type = CommandType.AddSong;
                    break;

                case Command.ADD_APPLICATION:
                    Type = CommandType.AddApplication;
                    break;

                case Command.UPDATE:
                    Type = CommandType.Update;
                    break;

                case Command.FIND:
                    Type = CommandType.Find;
                    break;

                default:
                    {
                        if (commandName.ToLower().Contains("book")
                           || commandName.ToLower().Contains("movie")
                           || commandName.ToLower().Contains("song")
                           || commandName.ToLower().Contains("application"))
                        {
                            throw new FormatException(String.Format("You are tring to add more than one item in the catalog at once."+
                                                                                        "Please add one at time when using 'add' command."));
                        }

                        if (commandName.ToLower().Contains("find")
                            || commandName.ToLower().Contains("update"))
                        {
                            throw new InvalidProgramException();
                        }

                        throw new FormatException(String.Format("You tring to find and update a specific item at once. This is not valid command operation!"));
                    }
            }

            return Type;
        }

        public string ParseName()
        {
            string name = this.OriginalForm.Substring(0, this.commandNameEndIndex);
            return name;
        }

        public string[] ParseParameters()
        {
            Int32 paramsLength = this.OriginalForm.Length - (this.commandNameEndIndex + 2);
            string paramsOriginalForm = this.OriginalForm.Substring(this.commandNameEndIndex + 2, paramsLength);
            string[] parameters = paramsOriginalForm.Split(paramsSeparators, StringSplitOptions.RemoveEmptyEntries);

            return parameters;
        }

        private Int32 GetCommandNameEndIndex()
        {
            Int32 endIndex = this.OriginalForm.IndexOf(commandEnd);

            return endIndex;
        }

        private void TrimParams()
        {
            for (int i = 0; i < this.Parameters.Length; i++)
            {
                this.Parameters[i] = this.Parameters[i].Trim();
            }
        }

        public override string ToString()
        {
            string toString = "" + this.Name + " ";

            foreach (string param in this.Parameters)
            {
                toString += param + " ";
            }

            return toString;
        }
    }
}
