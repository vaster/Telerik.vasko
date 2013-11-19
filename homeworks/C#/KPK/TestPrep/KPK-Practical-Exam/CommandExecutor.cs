using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    [ExcludeFromCodeCoverage]
    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog catalog, ICommand command, StringBuilder consoleOutput)
        {
            switch (command.Type)
            {
                case CommandType.AddBook:
                    this.AddBook(catalog, command, consoleOutput);
                    break;

                case CommandType.AddMovie:
                    this.AddMovie(catalog, command, consoleOutput);
                    break;

                case CommandType.AddSong:
                    this.AddSong(catalog, command, consoleOutput);
                    break;

                case CommandType.AddApplication:
                    this.AddAplication(catalog, command, consoleOutput);
                    break;

                case CommandType.Update:
                    this.Update(catalog, command, consoleOutput);
                    break;

                case CommandType.Find:
                    this.Find(catalog, command, consoleOutput);
                    break;

                default:
                    {
                        throw new InvalidCastException("Unknown command!");
                    }
            }
        }

        private void AddBook(ICatalog catalog, ICommand command, StringBuilder consoleOutput)
        {
            catalog.Add(new Content(CatalogItem.Book, command.Parameters));
            consoleOutput.AppendLine("Books Added");
        }

        private void AddMovie(ICatalog catalog, ICommand command, StringBuilder consoleOutput)
        {
            catalog.Add(new Content(CatalogItem.Movie, command.Parameters));
            consoleOutput.AppendLine("Movie added");
        }

        private void AddSong(ICatalog catalog, ICommand command, StringBuilder consoleOutput)
        {
            catalog.Add(new Content(CatalogItem.Song, command.Parameters));
            consoleOutput.AppendLine("Song added");
        }

        private void AddAplication(ICatalog catalog, ICommand command, StringBuilder consoleOutput)
        {
            catalog.Add(new Content(CatalogItem.Application, command.Parameters));
            consoleOutput.AppendLine("Application added");
        }

        private void Update(ICatalog catalog, ICommand command, StringBuilder consoleOutput)
        {
            if (command.Parameters.Length != 2)
            {
                throw new FormatException("Invalid number of parameters!Mandatory parameters are: Old url and new url. Probably some are missing.");
            }

            consoleOutput.AppendLine(String.Format("{0} items updated", catalog.UpdateContent(command.Parameters[0], command.Parameters[1])));
        }

        private void Find(ICatalog catalog, ICommand command, StringBuilder consoleOutput)
        {
            if (command.Parameters.Length != 2)
            {
                throw new FormatException("Invalid number of parameters!Mandatory parameters are: Title and count. Probably some are missing.");
            }

            Int32 numberOfElementsToList = Int32.Parse(command.Parameters[1]);
            IEnumerable<IContent> foundContent = catalog.GetListContent(command.Parameters[0], numberOfElementsToList);

            if (foundContent.Count() == 0)
            {
                consoleOutput.AppendLine("No items found");
            }
            else
            {
                foreach (IContent content in foundContent)
                {
                    consoleOutput.AppendLine(content.TextRepresentation);
                }
            }

        }
    }
}
