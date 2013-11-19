using System;

namespace Catalog
{
    public interface IContent : IComparable
    {
        string URL { get; set; }
        string TextRepresentation { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        Int64 Size { get; set; }
        CatalogItem Type { get; set; }
    }
}
