using System;
using System.Collections.Generic;
using System.Linq;
using Wintellect.PowerCollections;

namespace Catalog
{
    /// <summary>
    /// Add new content to the catalog.
    ///     Determine logic for further manipulation of the content.
    /// </summary>
    public interface ICatalog
    {
        /// <summary>
        /// Add current content's title and url to collections of data.
        /// </summary>
        /// <param name="content">A specifed content holding information about specific catalog items.</param>
        void Add(IContent content);

        /// <summary>
        /// Finds number instances of the class <see cref="Content"/> by search criteria.
        /// </summary>
        /// <param name="title">Determing the searched cirteria.</param>
        /// <param name="numberOfContentElementsToList">Determing the maximal number of contents to be collected.</param>
        /// <returns>List of items meeting this criterias. 
        ///     If number of founded contetents is lower than the desired number it returns only these which are found.</returns>
        IEnumerable<IContent> GetListContent(string title, Int32 numberOfContentElementsToList);

        /// <summary>
        /// Replace all occurences of urls with new ones.
        /// </summary>
        /// <param name="oldUrl">Url to be replaced.</param>
        /// <param name="newUrl">Url to replace withd.</param>
        /// <returns>Number of updated items.</returns>
        Int32 UpdateContent(string oldUrl, string newUrl);
    }
}
