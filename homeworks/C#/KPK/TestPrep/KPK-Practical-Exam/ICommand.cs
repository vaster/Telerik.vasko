using System;
using System.Linq;
using System.Text;

namespace Catalog
{
    public interface ICommand
    {
        string OriginalForm { get; set; }
        string Name { get; set; }
        string[] Parameters { get; set; }
        string ParseName();
        string[] ParseParameters();
        CommandType Type { get; set; }
        CommandType ParseCommandType(string commandName);
    }
}
