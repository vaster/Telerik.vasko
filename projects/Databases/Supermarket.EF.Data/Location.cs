//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supermarket.EF.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public Location()
        {
            this.SalesReports = new HashSet<SalesReport>();
        }
    
        public int LocationID { get; set; }
        public string Supermarket { get; set; }
    
        public virtual ICollection<SalesReport> SalesReports { get; set; }
    }
}