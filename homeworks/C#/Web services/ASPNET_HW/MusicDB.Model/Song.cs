//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MusicDB.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Song
    {
        public int Id { get; set; }
        public string SongTitle { get; set; }
        public System.DateTime Year { get; set; }
        public string Genre { get; set; }
        public int AlbumId { get; set; }
    
        public virtual Album Album { get; set; }
    }
}
